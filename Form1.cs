using localux.Models;
using System;
using System.Windows.Forms;

namespace localux
{
    public partial class Form1 : Form
    {
     //ancien code pour conflit
        public Form1()
        {
            InitializeComponent();
            InitMenu();
        }
       
        private void InitMenu()
        {
            // Supprimer les anciens menus 
            foreach (Control c in this.Controls)
            {
                if (c is MenuStrip)
                {
                    this.Controls.Remove(c);
                    break;
                }
            }

            var menuStrip = new MenuStrip();

            var menuEmploye = new ToolStripMenuItem("Employés");
            var itemCreerEmploye = new ToolStripMenuItem("Créer un employé", null, (s, e) =>
            {
                var f = new FormCreerEmployer();
                f.ShowDialog();
            });
            menuEmploye.DropDownItems.Add(itemCreerEmploye);


            ToolStripMenuItem menuConnexion;
            if (Session.UtilisateurConnecte == null)
            {
                menuConnexion = new ToolStripMenuItem("Connexion", null, (s, e) =>
                {
                    var f = new FormConnexion();
                    f.ShowDialog();
                    InitMenu(); // Actualise le menu après la connexion
                });
            }
            else
            {
                menuConnexion = new ToolStripMenuItem("Déconnexion", null, (s, e) =>
                {
                    Session.UtilisateurConnecte = null;
                    MessageBox.Show("Déconnexion réussie !");
                    InitMenu(); // Actualise le menu après la déconnexion
                });
            }

            var menuModifierMdp = new ToolStripMenuItem("Modifier mot de passe", null, (s, e) =>
            {
                var f = new FormModifierMdp();
                f.ShowDialog();
            });

            menuStrip.Items.Add(menuEmploye);
            menuStrip.Items.Add(menuConnexion);
            menuStrip.Items.Add(menuModifierMdp);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
    }
}
