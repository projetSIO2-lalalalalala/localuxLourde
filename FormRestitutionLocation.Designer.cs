namespace localux
{
    partial class FormRestitutionLocation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbNumero = new Label();
            lbClientNumero = new Label();
            lbClient = new Label();
            lbFormule = new Label();
            lbModele = new Label();
            lbImmat = new Label();
            lbDateDepart = new Label();
            lbDateRetour = new Label();
            lbNumeroValue = new Label();
            lbClientNumeroValue = new Label();
            lbClientValue = new Label();
            lbFormuleValue = new Label();
            lbModeleValue = new Label();
            lbImmatValue = new Label();
            lbDateDepartValue = new Label();
            lbDateRetourValue = new Label();
            gbControle = new GroupBox();
            lbEtatForm = new Label();
            lbEtatFormValue = new Label();
            btnEnregistrerRestitution = new Button();
            tbObservation = new TextBox();
            lbObservation = new Label();
            dgvDommages = new DataGridView();
            lbLegendeTypes = new Label();
            tbCoutEstimatif = new TextBox();
            lbCoutEstimatif = new Label();
            dtpDateRetour = new DateTimePicker();
            lbDateHeureControle = new Label();
            tbKilometrageRetour = new TextBox();
            lbKilometrageRetour = new Label();
            lbControleValue = new Label();
            gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDommages).BeginInit();
            SuspendLayout();
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNumero.Location = new Point(24, 21);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(118, 15);
            lbNumero.TabIndex = 0;
            lbNumero.Text = "Numéro de location";
            // 
            // lbClientNumero
            // 
            lbClientNumero.AutoSize = true;
            lbClientNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbClientNumero.Location = new Point(466, 21);
            lbClientNumero.Name = "lbClientNumero";
            lbClientNumero.Size = new Size(103, 15);
            lbClientNumero.TabIndex = 1;
            lbClientNumero.Text = "Numéro de client";
            // 
            // lbClient
            // 
            lbClient.AutoSize = true;
            lbClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbClient.Location = new Point(466, 49);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(129, 15);
            lbClient.TabIndex = 2;
            lbClient.Text = "Nom et prénom client";
            // 
            // lbFormule
            // 
            lbFormule.AutoSize = true;
            lbFormule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbFormule.Location = new Point(24, 49);
            lbFormule.Name = "lbFormule";
            lbFormule.Size = new Size(52, 15);
            lbFormule.TabIndex = 3;
            lbFormule.Text = "Formule";
            // 
            // lbModele
            // 
            lbModele.AutoSize = true;
            lbModele.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbModele.Location = new Point(24, 77);
            lbModele.Name = "lbModele";
            lbModele.Size = new Size(47, 15);
            lbModele.TabIndex = 4;
            lbModele.Text = "Modèle";
            // 
            // lbImmat
            // 
            lbImmat.AutoSize = true;
            lbImmat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbImmat.Location = new Point(24, 105);
            lbImmat.Name = "lbImmat";
            lbImmat.Size = new Size(88, 15);
            lbImmat.TabIndex = 5;
            lbImmat.Text = "Immatriculation";
            // 
            // lbDateDepart
            // 
            lbDateDepart.AutoSize = true;
            lbDateDepart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDateDepart.Location = new Point(466, 77);
            lbDateDepart.Name = "lbDateDepart";
            lbDateDepart.Size = new Size(151, 15);
            lbDateDepart.TabIndex = 6;
            lbDateDepart.Text = "Date et heure de départ";
            // 
            // lbDateRetour
            // 
            lbDateRetour.AutoSize = true;
            lbDateRetour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDateRetour.Location = new Point(466, 105);
            lbDateRetour.Name = "lbDateRetour";
            lbDateRetour.Size = new Size(140, 15);
            lbDateRetour.TabIndex = 7;
            lbDateRetour.Text = "Date et heure de retour";
            // 
            // lbNumeroValue
            // 
            lbNumeroValue.AutoSize = true;
            lbNumeroValue.Location = new Point(171, 21);
            lbNumeroValue.Name = "lbNumeroValue";
            lbNumeroValue.Size = new Size(12, 15);
            lbNumeroValue.TabIndex = 8;
            lbNumeroValue.Text = "-";
            // 
            // lbClientNumeroValue
            // 
            lbClientNumeroValue.AutoSize = true;
            lbClientNumeroValue.Location = new Point(621, 21);
            lbClientNumeroValue.Name = "lbClientNumeroValue";
            lbClientNumeroValue.Size = new Size(12, 15);
            lbClientNumeroValue.TabIndex = 9;
            lbClientNumeroValue.Text = "-";
            // 
            // lbClientValue
            // 
            lbClientValue.AutoSize = true;
            lbClientValue.Location = new Point(621, 49);
            lbClientValue.Name = "lbClientValue";
            lbClientValue.Size = new Size(12, 15);
            lbClientValue.TabIndex = 10;
            lbClientValue.Text = "-";
            // 
            // lbFormuleValue
            // 
            lbFormuleValue.AutoSize = true;
            lbFormuleValue.Location = new Point(171, 49);
            lbFormuleValue.Name = "lbFormuleValue";
            lbFormuleValue.Size = new Size(12, 15);
            lbFormuleValue.TabIndex = 11;
            lbFormuleValue.Text = "-";
            // 
            // lbModeleValue
            // 
            lbModeleValue.AutoSize = true;
            lbModeleValue.Location = new Point(171, 77);
            lbModeleValue.Name = "lbModeleValue";
            lbModeleValue.Size = new Size(12, 15);
            lbModeleValue.TabIndex = 12;
            lbModeleValue.Text = "-";
            // 
            // lbImmatValue
            // 
            lbImmatValue.AutoSize = true;
            lbImmatValue.Location = new Point(171, 105);
            lbImmatValue.Name = "lbImmatValue";
            lbImmatValue.Size = new Size(12, 15);
            lbImmatValue.TabIndex = 13;
            lbImmatValue.Text = "-";
            // 
            // lbDateDepartValue
            // 
            lbDateDepartValue.AutoSize = true;
            lbDateDepartValue.Location = new Point(621, 77);
            lbDateDepartValue.Name = "lbDateDepartValue";
            lbDateDepartValue.Size = new Size(12, 15);
            lbDateDepartValue.TabIndex = 14;
            lbDateDepartValue.Text = "-";
            // 
            // lbDateRetourValue
            // 
            lbDateRetourValue.AutoSize = true;
            lbDateRetourValue.Location = new Point(621, 105);
            lbDateRetourValue.Name = "lbDateRetourValue";
            lbDateRetourValue.Size = new Size(12, 15);
            lbDateRetourValue.TabIndex = 15;
            lbDateRetourValue.Text = "-";
            // 
            // gbControle
            // 
            gbControle.Controls.Add(lbEtatForm);
            gbControle.Controls.Add(lbEtatFormValue);
            gbControle.Controls.Add(btnEnregistrerRestitution);
            gbControle.Controls.Add(tbObservation);
            gbControle.Controls.Add(lbObservation);
            gbControle.Controls.Add(dgvDommages);
            gbControle.Controls.Add(lbLegendeTypes);
            gbControle.Controls.Add(tbCoutEstimatif);
            gbControle.Controls.Add(lbCoutEstimatif);
            gbControle.Controls.Add(dtpDateRetour);
            gbControle.Controls.Add(lbDateHeureControle);
            gbControle.Controls.Add(tbKilometrageRetour);
            gbControle.Controls.Add(lbKilometrageRetour);
            gbControle.Controls.Add(lbControleValue);
            gbControle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbControle.Location = new Point(24, 140);
            gbControle.Name = "gbControle";
            gbControle.Size = new Size(813, 475);
            gbControle.TabIndex = 16;
            gbControle.TabStop = false;
            gbControle.Text = "Restitution du véhicule";
            // 
            // lbEtatForm
            // 
            lbEtatForm.AutoSize = true;
            lbEtatForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbEtatForm.Location = new Point(18, 443);
            lbEtatForm.Name = "lbEtatForm";
            lbEtatForm.Size = new Size(33, 15);
            lbEtatForm.TabIndex = 12;
            lbEtatForm.Text = "Etat";
            // 
            // lbEtatFormValue
            // 
            lbEtatFormValue.AutoSize = true;
            lbEtatFormValue.Font = new Font("Segoe UI", 9F);
            lbEtatFormValue.Location = new Point(94, 443);
            lbEtatFormValue.Name = "lbEtatFormValue";
            lbEtatFormValue.Size = new Size(21, 15);
            lbEtatFormValue.TabIndex = 11;
            lbEtatFormValue.Text = "...";
            // 
            // btnEnregistrerRestitution
            // 
            btnEnregistrerRestitution.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnregistrerRestitution.Location = new Point(622, 432);
            btnEnregistrerRestitution.Name = "btnEnregistrerRestitution";
            btnEnregistrerRestitution.Size = new Size(171, 31);
            btnEnregistrerRestitution.TabIndex = 10;
            btnEnregistrerRestitution.Text = "Enregistrer la restitution";
            btnEnregistrerRestitution.UseVisualStyleBackColor = true;
            btnEnregistrerRestitution.Click += btnEnregistrerRestitution_Click;
            // 
            // tbObservation
            // 
            tbObservation.Font = new Font("Segoe UI", 9F);
            tbObservation.Location = new Point(18, 343);
            tbObservation.MaxLength = 255;
            tbObservation.Multiline = true;
            tbObservation.Name = "tbObservation";
            tbObservation.Size = new Size(775, 73);
            tbObservation.TabIndex = 9;
            // 
            // lbObservation
            // 
            lbObservation.AutoSize = true;
            lbObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbObservation.Location = new Point(18, 325);
            lbObservation.Name = "lbObservation";
            lbObservation.Size = new Size(78, 15);
            lbObservation.TabIndex = 8;
            lbObservation.Text = "Observations";
            // 
            // dgvDommages
            // 
            dgvDommages.AllowUserToAddRows = false;
            dgvDommages.AllowUserToDeleteRows = false;
            dgvDommages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDommages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDommages.Location = new Point(18, 120);
            dgvDommages.MultiSelect = false;
            dgvDommages.Name = "dgvDommages";
            dgvDommages.RowHeadersVisible = false;
            dgvDommages.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvDommages.Size = new Size(775, 187);
            dgvDommages.TabIndex = 7;
            dgvDommages.CellValueChanged += dgvDommages_CellValueChanged;
            dgvDommages.CurrentCellDirtyStateChanged += dgvDommages_CurrentCellDirtyStateChanged;
            // 
            // lbLegendeTypes
            // 
            lbLegendeTypes.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLegendeTypes.Location = new Point(18, 309);
            lbLegendeTypes.Name = "lbLegendeTypes";
            lbLegendeTypes.Size = new Size(775, 16);
            lbLegendeTypes.TabIndex = 13;
            lbLegendeTypes.Text = "RS : Rayure superficielle ; RP : Rayure profonde ; EC : Enfoncement/Choc";
            // 
            // tbCoutEstimatif
            // 
            tbCoutEstimatif.Font = new Font("Segoe UI", 9F);
            tbCoutEstimatif.Location = new Point(581, 73);
            tbCoutEstimatif.Name = "tbCoutEstimatif";
            tbCoutEstimatif.Size = new Size(212, 23);
            tbCoutEstimatif.TabIndex = 6;
            // 
            // lbCoutEstimatif
            // 
            lbCoutEstimatif.AutoSize = true;
            lbCoutEstimatif.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCoutEstimatif.Location = new Point(429, 76);
            lbCoutEstimatif.Name = "lbCoutEstimatif";
            lbCoutEstimatif.Size = new Size(130, 15);
            lbCoutEstimatif.TabIndex = 5;
            lbCoutEstimatif.Text = "Coût estimatif (euros)";
            // 
            // dtpDateRetour
            // 
            dtpDateRetour.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDateRetour.Font = new Font("Segoe UI", 9F);
            dtpDateRetour.Format = DateTimePickerFormat.Custom;
            dtpDateRetour.Location = new Point(581, 35);
            dtpDateRetour.Name = "dtpDateRetour";
            dtpDateRetour.Size = new Size(212, 23);
            dtpDateRetour.TabIndex = 4;
            // 
            // lbDateHeureControle
            // 
            lbDateHeureControle.AutoSize = true;
            lbDateHeureControle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDateHeureControle.Location = new Point(429, 39);
            lbDateHeureControle.Name = "lbDateHeureControle";
            lbDateHeureControle.Size = new Size(119, 15);
            lbDateHeureControle.TabIndex = 3;
            lbDateHeureControle.Text = "Date - Heure retour";
            // 
            // tbKilometrageRetour
            // 
            tbKilometrageRetour.Font = new Font("Segoe UI", 9F);
            tbKilometrageRetour.Location = new Point(150, 73);
            tbKilometrageRetour.Name = "tbKilometrageRetour";
            tbKilometrageRetour.Size = new Size(212, 23);
            tbKilometrageRetour.TabIndex = 2;
            // 
            // lbKilometrageRetour
            // 
            lbKilometrageRetour.AutoSize = true;
            lbKilometrageRetour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbKilometrageRetour.Location = new Point(18, 76);
            lbKilometrageRetour.Name = "lbKilometrageRetour";
            lbKilometrageRetour.Size = new Size(122, 15);
            lbKilometrageRetour.TabIndex = 1;
            lbKilometrageRetour.Text = "Kilométrage retour";
            // 
            // lbControleValue
            // 
            lbControleValue.AutoSize = true;
            lbControleValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbControleValue.Location = new Point(18, 32);
            lbControleValue.Name = "lbControleValue";
            lbControleValue.Size = new Size(18, 19);
            lbControleValue.TabIndex = 0;
            lbControleValue.Text = "-";
            // 
            // FormRestitutionLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 633);
            Controls.Add(gbControle);
            Controls.Add(lbDateRetourValue);
            Controls.Add(lbDateDepartValue);
            Controls.Add(lbImmatValue);
            Controls.Add(lbModeleValue);
            Controls.Add(lbFormuleValue);
            Controls.Add(lbClientValue);
            Controls.Add(lbClientNumeroValue);
            Controls.Add(lbNumeroValue);
            Controls.Add(lbDateRetour);
            Controls.Add(lbDateDepart);
            Controls.Add(lbImmat);
            Controls.Add(lbModele);
            Controls.Add(lbFormule);
            Controls.Add(lbClient);
            Controls.Add(lbClientNumero);
            Controls.Add(lbNumero);
            Name = "FormRestitutionLocation";
            Text = "Restitution d'un véhicule";
            gbControle.ResumeLayout(false);
            gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDommages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumero;
        private Label lbClientNumero;
        private Label lbClient;
        private Label lbFormule;
        private Label lbModele;
        private Label lbImmat;
        private Label lbDateDepart;
        private Label lbDateRetour;
        private Label lbNumeroValue;
        private Label lbClientNumeroValue;
        private Label lbClientValue;
        private Label lbFormuleValue;
        private Label lbModeleValue;
        private Label lbImmatValue;
        private Label lbDateDepartValue;
        private Label lbDateRetourValue;
        private GroupBox gbControle;
        private Label lbControleValue;
        private TextBox tbKilometrageRetour;
        private Label lbKilometrageRetour;
        private DateTimePicker dtpDateRetour;
        private Label lbDateHeureControle;
        private TextBox tbCoutEstimatif;
        private Label lbCoutEstimatif;
        private DataGridView dgvDommages;
        private TextBox tbObservation;
        private Label lbObservation;
        private Button btnEnregistrerRestitution;
        private Label lbEtatFormValue;
        private Label lbEtatForm;
        private Label lbLegendeTypes;
    }
}
