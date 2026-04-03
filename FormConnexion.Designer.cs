namespace localux
{
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lbLogin = new Label();
            lbMdp = new Label();
            tbLogin = new TextBox();
            tbMdp = new TextBox();
            btn = new Button();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(70, 39);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(34, 15);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "login";
            // 
            // lbMdp
            // 
            lbMdp.AutoSize = true;
            lbMdp.Location = new Point(69, 80);
            lbMdp.Name = "lbMdp";
            lbMdp.Size = new Size(32, 15);
            lbMdp.TabIndex = 1;
            lbMdp.Text = "mdp";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(166, 40);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 2;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(164, 85);
            tbMdp.Name = "tbMdp";
            tbMdp.PasswordChar = '*';
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 3;
            // 
            // btn
            // 
            btn.Location = new Point(150, 147);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 4;
            btn.Text = "Valider";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(tbMdp);
            Controls.Add(tbLogin);
            Controls.Add(lbMdp);
            Controls.Add(lbLogin);
            Name = "FormConnexion";
            Text = "FormConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbMdp;
        private TextBox tbLogin;
        private TextBox tbMdp;
        private Button btn;
    }
}