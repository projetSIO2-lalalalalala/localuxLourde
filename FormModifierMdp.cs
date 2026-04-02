using localux.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace localux
{
    public partial class FormModifierMdp : Form
    {
        private MonDbContext cnx = new MonDbContext();
        

        public FormModifierMdp()
        {
            InitializeComponent();
        }

        private void FormModifierMdp_Load(object sender, EventArgs e)
        {
            if (Session.UtilisateurConnecte == null)
            {
                MessageBox.Show("Vous devez être connecté.");

                using (FormConnexion f = new FormConnexion())
                {
                    var result = f.ShowDialog();
                    if (Session.UtilisateurConnecte == null)
                    {
                        // L'utilisateur n'est toujours pas connecté, on ferme ce formulaire
                        this.Close();
                        return;
                    }
                }
            }

            var employe = Session.UtilisateurConnecte;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string nouveauMdp = tbMdp.Text;
            string confirmMdp = tbConfirmerMdp.Text;

            if (nouveauMdp != confirmMdp)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            var employe = Session.UtilisateurConnecte;

            var anciensMdp = cnx.HistoriqueMdp
                .Where(h => h.LeEmployeId == employe.Id)
                .OrderByDescending(h => h.DateModification)
                .Select(h => h.Mdp)
                .ToList();

            if (anciensMdp.Any(m => BCrypt.Net.BCrypt.Verify(nouveauMdp, m)))
            {
                MessageBox.Show("Vous ne pouvez pas réutiliser un ancien mot de passe.");
                return;
            }

            // Hash du nouveau mot de passe
            string hashMdp = BCrypt.Net.BCrypt.HashPassword(nouveauMdp);

            // Mise à jour de l'employé
            var employeDb = cnx.Employe.FirstOrDefault(e => e.Id == employe.Id);
            if (employeDb != null)
            {
                employeDb.Mdp = hashMdp;
                employeDb.DateModificationMdp = DateTime.Now;

                // Ajout à l'historique
                var historique = new HistoriqueMdp
                {
                    Mdp = hashMdp,
                    DateModification = DateTime.Now,
                    LeEmployeId = employe.Id
                };
                cnx.HistoriqueMdp.Add(historique);

                cnx.SaveChanges();

                MessageBox.Show("Mot de passe modifié avec succès.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification du mot de passe.");
            }
        }
    }
}
