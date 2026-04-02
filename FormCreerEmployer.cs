using System;
using System.Linq;
using System.Windows.Forms;
using localux.Models;
using BCrypt.Net;

namespace localux
{
    public partial class FormCreerEmployer : Form
    {
        private MonDbContext cnx = new MonDbContext();

        public FormCreerEmployer()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text.Trim();
            string prenom = tbPrenom.Text.Trim();
            string login = tbLogin.Text.Trim();
            string mdp = tbMdp.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mdp))
            {
                MessageBox.Show("Tous les champs sont obligatoires.");
                return;
            }

            if (cnx.Employe.Any(emp => emp.Login == login))
            {
                MessageBox.Show("Ce login existe déjà.");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(mdp);

            var employe = new Employe
            {
                Nom = nom,
                Prenom = prenom,
                Login = login,
                Mdp = hash,
                DateModificationMdp = DateTime.Now
            };

            cnx.Employe.Add(employe);
            cnx.SaveChanges();

            var historique = new HistoriqueMdp
            {
                Mdp = hash,
                DateModification = DateTime.Now,
                LeEmployeId = employe.Id
            };
            cnx.HistoriqueMdp.Add(historique);
            cnx.SaveChanges();

            MessageBox.Show("Employé créé avec succès !");
            this.Close();
        }

        private void FormCreerEmployer_Load(object sender, EventArgs e)
        {

        }
    }
}
