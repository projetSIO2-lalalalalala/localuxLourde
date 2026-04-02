using localux.Models;
using System;
using System.Windows.Forms;

namespace localux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Création du menu
            var menuStrip = new MenuStrip();

            var menuEmploye = new ToolStripMenuItem("Employés");
            var itemCreerEmploye = new ToolStripMenuItem("Créer un employé", null, (s, e) => {
                var f = new FormCreerEmployer();
                f.ShowDialog();
            });

            var menuConnexion = new ToolStripMenuItem("Connexion", null, (s, e) => {
                var f = new FormConnexion();
                f.ShowDialog();
            });

            var menuModifierMdp = new ToolStripMenuItem("Modifier mot de passe", null, (s, e) => {
                var f = new FormModifierMdp();
                f.ShowDialog();
            });

            menuEmploye.DropDownItems.Add(itemCreerEmploye);
            menuStrip.Items.Add(menuEmploye);
            menuStrip.Items.Add(menuConnexion);
            menuStrip.Items.Add(menuModifierMdp);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
    }
}
