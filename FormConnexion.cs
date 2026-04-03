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
using System.Security.Cryptography;
using BCrypt.Net;


namespace localux
{
    public partial class FormConnexion : Form
    {
        private MonDbContext cnx = new MonDbContext();
        public FormConnexion()
        {
            InitializeComponent();
            
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string mdp = tbMdp.Text;
            var employe = cnx.Employe.FirstOrDefault(emp => emp.Login == login);

            Session.UtilisateurConnecte = employe;

            if (employe == null)
            {
                MessageBox.Show("Utilisateur inconnu.");
                return;
            }

            bool mdpValide = BCrypt.Net.BCrypt.Verify(mdp, employe.Mdp);

            if (mdpValide)
            {
                MessageBox.Show("Connexion réussie !");
                this.Close(); 
                return;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect.");
            }

            if (employe.DateModificationMdp == null || (DateTime.Now - employe.DateModificationMdp.Value).TotalDays > 30)
            {
                MessageBox.Show("Votre mot de passe doit être changé. Veuillez le modifier.");
                FormModifierMdp f = new FormModifierMdp();
                f.Show();
                this.Close();
            }
        }
    }
}
