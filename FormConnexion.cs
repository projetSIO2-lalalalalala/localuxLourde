using System;
using System.Linq;
using System.Windows.Forms;
using localux.Models;

namespace localux
{
    public partial class FormConnexion : Form
    {
        private readonly MonDbContext cnx = new();

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string mdp = tbMdp.Text;

            var employe = cnx.Employe.FirstOrDefault(emp => emp.Login == login);
            if (employe == null)
            {
                MessageBox.Show("Utilisateur inconnu.");
                return;
            }

            bool mdpValide = BCrypt.Net.BCrypt.Verify(mdp, employe.Mdp);

            if (mdpValide)
            {
                MessageBox.Show("Connexion réussie !");
                Session.UtilisateurConnecte = employe;
                AjouterLogConnexion(employe, "Connexion réussie");
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect.");
                AjouterLogConnexion(employe, "Connexion échouée");
                return;
            }

            if (employe.DateModificationMdp == null || (DateTime.Now - employe.DateModificationMdp.Value).TotalDays > 30)
            {
                MessageBox.Show("Votre mot de passe a expiré, veuillez le modifier.");
                using (var f = new FormModifierMdp())
                {
                    f.ShowDialog();
                }
            }

            this.Close();
        }

        private void AjouterLogConnexion(Employe employe, string action)
        {
            var log = new LogConnexion
            {
                DateHeure = DateTime.Now,
                Action = action,
                LeEmploye = employe,
                LeEmployeId = employe.Id
            };
            cnx.LogConnexion.Add(log);
            cnx.SaveChanges();
        }
    }
}
