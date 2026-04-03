namespace localux
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbLocationId = new Label();
            tbLocationId = new TextBox();
            btnVoirLocation = new Button();
            SuspendLayout();
            // 
            // lbLocationId
            // 
            lbLocationId.AutoSize = true;
            lbLocationId.Location = new Point(32, 50);
            lbLocationId.Name = "lbLocationId";
            lbLocationId.Size = new Size(165, 15);
            lbLocationId.TabIndex = 0;
            lbLocationId.Text = "Numéro de location (sans chauffeur)";
            // 
            // tbLocationId
            // 
            tbLocationId.Location = new Point(32, 72);
            tbLocationId.Name = "tbLocationId";
            tbLocationId.Size = new Size(200, 23);
            tbLocationId.TabIndex = 1;
            // 
            // btnVoirLocation
            // 
            btnVoirLocation.Location = new Point(32, 109);
            btnVoirLocation.Name = "btnVoirLocation";
            btnVoirLocation.Size = new Size(200, 23);
            btnVoirLocation.TabIndex = 2;
            btnVoirLocation.Text = "Voir la location";
            btnVoirLocation.UseVisualStyleBackColor = true;
            btnVoirLocation.Click += btnVoirLocation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoirLocation);
            Controls.Add(tbLocationId);
            Controls.Add(lbLocationId);
            Name = "Form1";
            Text = "Accueil";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbLocationId;
        private TextBox tbLocationId;
        private Button btnVoirLocation;
    }
}
