namespace localux
{
    partial class FormCreerEmployer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNom = new TextBox();
            tbPrenom = new TextBox();
            tbLogin = new TextBox();
            tbMdp = new TextBox();
            btnCreer = new Button();
            lblNom = new Label();
            lblPrenom = new Label();
            lblLogin = new Label();
            lblMdp = new Label();
            SuspendLayout();
            // 
            // tbNom
            // 
            tbNom.Location = new Point(120, 17);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(150, 23);
            tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(120, 57);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(150, 23);
            tbPrenom.TabIndex = 3;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(120, 97);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(150, 23);
            tbLogin.TabIndex = 5;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(120, 137);
            tbMdp.Name = "tbMdp";
            tbMdp.PasswordChar = '*';
            tbMdp.Size = new Size(150, 23);
            tbMdp.TabIndex = 7;
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(120, 180);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(150, 30);
            btnCreer.TabIndex = 8;
            btnCreer.Text = "Créer l'employé";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(20, 20);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(20, 60);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(20, 100);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(20, 140);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(77, 15);
            lblMdp.TabIndex = 6;
            lblMdp.Text = "Mot de passe";
            // 
            // FormCreerEmployer
            // 
            ClientSize = new Size(300, 230);
            Controls.Add(lblNom);
            Controls.Add(tbNom);
            Controls.Add(lblPrenom);
            Controls.Add(tbPrenom);
            Controls.Add(lblLogin);
            Controls.Add(tbLogin);
            Controls.Add(lblMdp);
            Controls.Add(tbMdp);
            Controls.Add(btnCreer);
            Name = "FormCreerEmployer";
            Text = "Créer un employé";
            Load += FormCreerEmployer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}