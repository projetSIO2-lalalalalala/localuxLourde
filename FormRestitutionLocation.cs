using localux.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace localux
{
    public partial class FormRestitutionLocation : Form
    {
        private readonly MonDbContext db = new MonDbContext();
        private readonly LocationSansChauffeur location;
        private List<TypeDommage> typesDommage = new();
        private bool isLectureSeule;

        public FormRestitutionLocation(LocationSansChauffeur location)
        {
            this.location = db.Location
                .OfType<LocationSansChauffeur>()
                .Include(l => l.LaFormule)
                .Include(l => l.LeVehicule)
                .ThenInclude(v => v.LeModele)
                .Include(l => l.LeClient)
                .Include(l => l.LeEmploye)
                .First(l => l.Id == location.Id);

            InitializeComponent();
            ChargerRecapitulatif();
            ChargerTypesDommage();
            ChargerComposantsEtDommages();
            InitialiserControlesSaisie();
            AppliquerModeLectureSeuleSiRestituee();
        }

        private void ChargerRecapitulatif()
        {
            lbNumeroValue.Text = location.Id.ToString();
            lbClientNumeroValue.Text = location.LeClientId.ToString();
            lbClientValue.Text = $"{location.LeClient.Nom} {location.LeClient.Prenom}";
            lbFormuleValue.Text = location.LaFormule?.Libelle ?? "-";
            lbModeleValue.Text = location.LeVehicule.LeModele.Libelle;
            lbImmatValue.Text = location.LeVehicule.Immat;
            lbDateDepartValue.Text = location.DateHeureDepart.ToString("g");
            lbDateRetourValue.Text = location.DateHeureRetour?.ToString("g") ?? "-";
        }

        private void ChargerTypesDommage()
        {
            typesDommage = db.TypeDommage.OrderBy(t => t.Id).ToList();
            InitialiserColonnesDommages();
            ChargerLegendeTypesDommage();
        }

        private void InitialiserColonnesDommages()
        {
            dgvDommages.Columns.Clear();

            dgvDommages.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colComposant",
                HeaderText = "Composant",
                ReadOnly = true,
                FillWeight = 210F
            });

            foreach (var type in typesDommage)
            {
                dgvDommages.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = $"colType{type.Id}",
                    HeaderText = type.Libelle,
                    FillWeight = 60F
                });
            }
        }

        private void ChargerLegendeTypesDommage()
        {
            var libellesComplets = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["RS"] = "Rayure superficielle",
                ["RP"] = "Rayure profonde",
                ["EC"] = "Enfoncement/Choc"
            };

            var legendes = typesDommage.Select(t =>
            {
                var code = t.Libelle?.Trim() ?? string.Empty;
                if (libellesComplets.TryGetValue(code, out var texteComplet))
                {
                    return $"{code} : {texteComplet}";
                }

                return $"{code} : {code}";
            });

            lbLegendeTypes.Text = string.Join(" ; ", legendes);
        }

        private void ChargerComposantsEtDommages()
        {
            var composants = db.Composant
                .Where(c => c.Modeles.Any(m => m.Id == location.LeVehicule.LeModeleId))
                .OrderBy(c => c.Libelle)
                .ToList();

            if (composants.Count == 0)
            {
                composants = db.Composant.OrderBy(c => c.Libelle).ToList();
            }

            var dommagesExistants = db.DommageControle
                .Where(d => d.LaLocationId == location.Id)
                .ToList()
                .GroupBy(d => d.LeComposantId)
                .ToDictionary(g => g.Key, g => g.Select(x => x.LeTypeDommageId).ToHashSet());

            dgvDommages.Rows.Clear();

            foreach (var composant in composants)
            {
                var valeursLigne = new object[typesDommage.Count + 1];
                valeursLigne[0] = composant.Libelle;

                for (var i = 0; i < typesDommage.Count; i++)
                {
                    valeursLigne[i + 1] = EstTypeCoche(dommagesExistants, composant.Id, typesDommage[i].Id);
                }

                var rowIndex = dgvDommages.Rows.Add(valeursLigne);

                dgvDommages.Rows[rowIndex].Tag = composant.Id;
            }
        }

        private static bool EstTypeCoche(Dictionary<int, HashSet<int>> dommagesExistants, int composantId, int typeId)
        {
            return dommagesExistants.TryGetValue(composantId, out var types) && types.Contains(typeId);
        }

        private void InitialiserControlesSaisie()
        {
            tbKilometrageRetour.Text = location.KilometrageRetour?.ToString() ?? string.Empty;
            tbCoutEstimatif.Text = location.CoutEstimatif?.ToString() ?? string.Empty;
            tbObservation.Text = location.Observation ?? string.Empty;
            dtpDateRetour.Value = location.DateHeureRetour ?? DateTime.Now;

            var nomEmploye = location.LeEmploye != null
                ? $"{location.LeEmploye.Prenom} {location.LeEmploye.Nom}"
                : Session.UtilisateurConnecte != null
                    ? $"{Session.UtilisateurConnecte.Prenom} {Session.UtilisateurConnecte.Nom}"
                    : "-";

            lbControleValue.Text = $"Contrôle n°{location.Id} réalisé par {nomEmploye}";
        }

        private void AppliquerModeLectureSeuleSiRestituee()
        {
            isLectureSeule = location.LeEmployeId.HasValue;

            if (!isLectureSeule)
            {
                return;
            }

            tbKilometrageRetour.ReadOnly = true;
            tbCoutEstimatif.ReadOnly = true;
            tbObservation.ReadOnly = true;
            dtpDateRetour.Enabled = false;
            dgvDommages.ReadOnly = true;
            btnEnregistrerRestitution.Enabled = false;
            lbEtatFormValue.Text = "Restitution déjà enregistrée";
        }

        private void btnEnregistrerRestitution_Click(object sender, EventArgs e)
        {
            if (isLectureSeule)
            {
                return;
            }

            if (Session.UtilisateurConnecte == null)
            {
                MessageBox.Show("Veuillez vous connecter.");
                return;
            }

            if (!int.TryParse(tbKilometrageRetour.Text, out var kilometrageRetour) || kilometrageRetour < 0)
            {
                MessageBox.Show("Le kilométrage retour est invalide.");
                return;
            }

            int? coutEstimatif = null;
            if (!string.IsNullOrWhiteSpace(tbCoutEstimatif.Text))
            {
                if (!int.TryParse(tbCoutEstimatif.Text, out var cout) || cout < 0)
                {
                    MessageBox.Show("Le coût estimatif est invalide.");
                    return;
                }

                coutEstimatif = cout;
            }

            location.KilometrageRetour = kilometrageRetour;
            location.CoutEstimatif = coutEstimatif;
            location.Observation = string.IsNullOrWhiteSpace(tbObservation.Text)
                ? null
                : tbObservation.Text.Trim();
            location.DateHeureRetour = dtpDateRetour.Value;
            location.LeEmployeId = Session.UtilisateurConnecte.Id;

            var existants = db.DommageControle.Where(d => d.LaLocationId == location.Id);
            db.DommageControle.RemoveRange(existants);

            foreach (DataGridViewRow row in dgvDommages.Rows)
            {
                if (row.IsNewRow || row.Tag is not int composantId)
                {
                    continue;
                }

                foreach (var type in typesDommage)
                {
                    AjouterDommageSiCoche(row, $"colType{type.Id}", composantId, type.Id);
                }
            }

            db.SaveChanges();
            MessageBox.Show("Restitution enregistrée.");
            lbDateRetourValue.Text = location.DateHeureRetour?.ToString("g") ?? "-";
            lbEtatFormValue.Text = "Restitution enregistrée";
            isLectureSeule = true;
            AppliquerModeLectureSeuleSiRestituee();
        }

        private void AjouterDommageSiCoche(DataGridViewRow row, string columnName, int composantId, int typeDommageId)
        {
            var coche = row.Cells[columnName].Value as bool? == true;
            if (!coche)
            {
                return;
            }

            db.DommageControle.Add(new DommageControle
            {
                LaLocationId = location.Id,
                LeComposantId = composantId,
                LeTypeDommageId = typeDommageId
            });
        }

        private void dgvDommages_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDommages.IsCurrentCellDirty)
            {
                dgvDommages.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvDommages_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var nomColonne = dgvDommages.Columns[e.ColumnIndex].Name;
            if (!nomColonne.StartsWith("colType", StringComparison.Ordinal))
            {
                return;
            }

            var value = dgvDommages.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as bool?;
            if (value != true)
            {
                return;
            }

            foreach (DataGridViewColumn colonne in dgvDommages.Columns)
            {
                if (!colonne.Name.StartsWith("colType", StringComparison.Ordinal) || colonne.Name == nomColonne)
                {
                    continue;
                }

                dgvDommages.Rows[e.RowIndex].Cells[colonne.Name].Value = false;
            }
        }
    }
}
