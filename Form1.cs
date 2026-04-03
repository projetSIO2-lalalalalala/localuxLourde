using localux.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace localux
{
    public partial class Form1 : Form
    {
     //nouveau code pour conflit
        private readonly MonDbContext db = new MonDbContext();

        public Form1()
        {
            InitializeComponent();

            var menuStrip = new MenuStrip();

            var menuEmploye = new ToolStripMenuItem("Employés");
            var itemCreerEmploye = new ToolStripMenuItem("Créer un employé", null, (s, e) =>
            {
                var f = new FormCreerEmployer();
                f.ShowDialog();
            });

            var menuConnexion = new ToolStripMenuItem("Connexion", null, (s, e) =>
            {
                var f = new FormConnexion();
                f.ShowDialog();
                UpdateConnexionState();
            });

            var menuModifierMdp = new ToolStripMenuItem("Modifier mot de passe", null, (s, e) =>
            {
                var f = new FormModifierMdp();
                f.ShowDialog();
            });

            menuEmploye.DropDownItems.Add(itemCreerEmploye);
            menuStrip.Items.Add(menuEmploye);
            menuStrip.Items.Add(menuConnexion);
            menuStrip.Items.Add(menuModifierMdp);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            UpdateConnexionState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateConnexionState();
        }

        private void UpdateConnexionState()
        {
            var connecte = Session.UtilisateurConnecte != null;
            lbLocationId.Enabled = connecte;
            tbLocationId.Enabled = connecte;
            btnVoirLocation.Enabled = connecte;

            if (!connecte)
            {
                tbLocationId.Clear();
            }
        }

        private void btnVoirLocation_Click(object sender, EventArgs e)
        {
            if (Session.UtilisateurConnecte == null)
            {
                MessageBox.Show("Veuillez vous connecter.");
                return;
            }

            if (!int.TryParse(tbLocationId.Text, out var locationId))
            {
                MessageBox.Show("Veuillez saisir un numéro de location valide.");
                return;
            }

            var location = db.Location
                .OfType<LocationSansChauffeur>()
                .Include(l => l.LaFormule)
                .Include(l => l.LeVehicule)
                .ThenInclude(v => v.LeModele)
                .Include(l => l.LeClient)
                .FirstOrDefault(l => l.Id == locationId);

            if (location == null)
            {
                MessageBox.Show("Aucune location valide trouvée pour ce numéro.");
                return;
            }

            using var form = new FormRestitutionLocation(location);
            form.ShowDialog();
        }
    }
}
