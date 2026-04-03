namespace localux
{
    partial class FormModifierMdp
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
            lbMdp = new Label();
            tbMdp = new TextBox();
            tbConfirmerMdp = new TextBox();
            lbConfirmerMdp = new Label();
            btn = new Button();
            lbPin = new Label();
            tbPin = new TextBox();
            SuspendLayout();
            // 
            // lbMdp
            // 
            lbMdp.AutoSize = true;
            lbMdp.Location = new Point(212, 84);
            lbMdp.Name = "lbMdp";
            lbMdp.Size = new Size(81, 15);
            lbMdp.TabIndex = 0;
            lbMdp.Text = "nouveau mdp";
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(327, 84);
            tbMdp.Name = "tbMdp";
            tbMdp.PasswordChar = '*';
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 1;
            // 
            // tbConfirmerMdp
            // 
            tbConfirmerMdp.Location = new Point(327, 148);
            tbConfirmerMdp.Name = "tbConfirmerMdp";
            tbConfirmerMdp.PasswordChar = '*';
            tbConfirmerMdp.Size = new Size(100, 23);
            tbConfirmerMdp.TabIndex = 2;
            // 
            // lbConfirmerMdp
            // 
            lbConfirmerMdp.AutoSize = true;
            lbConfirmerMdp.Location = new Point(211, 154);
            lbConfirmerMdp.Name = "lbConfirmerMdp";
            lbConfirmerMdp.Size = new Size(89, 15);
            lbConfirmerMdp.TabIndex = 3;
            lbConfirmerMdp.Text = "Confirmer mdp";
            // 
            // btn
            // 
            btn.Location = new Point(334, 251);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 4;
            btn.Text = "modifier";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lbPin
            // 
            lbPin.AutoSize = true;
            lbPin.Location = new Point(217, 200);
            lbPin.Name = "lbPin";
            lbPin.Size = new Size(53, 15);
            lbPin.TabIndex = 5;
            lbPin.Text = "code pin";
            // 
            // tbPin
            // 
            tbPin.Location = new Point(327, 200);
            tbPin.Name = "tbPin";
            tbPin.Size = new Size(100, 23);
            tbPin.TabIndex = 6;
            // 
            // FormModifierMdp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPin);
            Controls.Add(lbPin);
            Controls.Add(btn);
            Controls.Add(lbConfirmerMdp);
            Controls.Add(tbConfirmerMdp);
            Controls.Add(tbMdp);
            Controls.Add(lbMdp);
            Name = "FormModifierMdp";
            Text = "FormModifierMdp";
            Load += FormModifierMdp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMdp;
        private TextBox tbMdp;
        private TextBox tbConfirmerMdp;
        private Label lbConfirmerMdp;
        private Button btn;
        private Label lbPin;
        private TextBox tbPin;
    }
}