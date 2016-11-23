namespace RouleTitine
{
    partial class GestionEntretien
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
            this.components = new System.ComponentModel.Container();
            this.splitGestionEntretien = new System.Windows.Forms.SplitContainer();
            this.splitCalendrier = new System.Windows.Forms.SplitContainer();
            this.lblCalDate = new System.Windows.Forms.Label();
            this.dataEntretienDate = new System.Windows.Forms.DataGridView();
            this.lblCalKm = new System.Windows.Forms.Label();
            this.dataEntretienKm = new System.Windows.Forms.DataGridView();
            this.splitSaisieEntretien = new System.Windows.Forms.SplitContainer();
            this.gbNouvelEntretien = new System.Windows.Forms.GroupBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.cbLstEntretiens = new System.Windows.Forms.ComboBox();
            this.btnAnnulerEntretien = new System.Windows.Forms.Button();
            this.lblGarage = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.btnEnregistrerEntretien = new System.Windows.Forms.Button();
            this.cbLstGarages = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblNmPiece = new System.Windows.Forms.Label();
            this.txtCommentaireEntretien = new System.Windows.Forms.TextBox();
            this.datePickerDtEntretien = new System.Windows.Forms.DateTimePicker();
            this.lblEntretienFait = new System.Windows.Forms.Label();
            this.lblKmEntretien = new System.Windows.Forms.Label();
            this.txtNomPiece = new System.Windows.Forms.TextBox();
            this.txtMtEntretien = new System.Windows.Forms.TextBox();
            this.lblDateEntretien = new System.Windows.Forms.Label();
            this.txtKilometrageEntretien = new System.Windows.Forms.TextBox();
            this.btnSaisirEntretien = new System.Windows.Forms.Button();
            this.dataHistEntretien = new System.Windows.Forms.DataGridView();
            this.lblEntretienPasse = new System.Windows.Forms.Label();
            this.tlTipPieceRemp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitGestionEntretien)).BeginInit();
            this.splitGestionEntretien.Panel1.SuspendLayout();
            this.splitGestionEntretien.Panel2.SuspendLayout();
            this.splitGestionEntretien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCalendrier)).BeginInit();
            this.splitCalendrier.Panel1.SuspendLayout();
            this.splitCalendrier.Panel2.SuspendLayout();
            this.splitCalendrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntretienDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntretienKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitSaisieEntretien)).BeginInit();
            this.splitSaisieEntretien.Panel1.SuspendLayout();
            this.splitSaisieEntretien.Panel2.SuspendLayout();
            this.splitSaisieEntretien.SuspendLayout();
            this.gbNouvelEntretien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistEntretien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitGestionEntretien
            // 
            this.splitGestionEntretien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGestionEntretien.Location = new System.Drawing.Point(0, 0);
            this.splitGestionEntretien.Name = "splitGestionEntretien";
            this.splitGestionEntretien.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGestionEntretien.Panel1
            // 
            this.splitGestionEntretien.Panel1.Controls.Add(this.splitCalendrier);
            // 
            // splitGestionEntretien.Panel2
            // 
            this.splitGestionEntretien.Panel2.Controls.Add(this.splitSaisieEntretien);
            this.splitGestionEntretien.Size = new System.Drawing.Size(909, 714);
            this.splitGestionEntretien.SplitterDistance = 300;
            this.splitGestionEntretien.TabIndex = 0;
            // 
            // splitCalendrier
            // 
            this.splitCalendrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCalendrier.Location = new System.Drawing.Point(0, 0);
            this.splitCalendrier.Name = "splitCalendrier";
            // 
            // splitCalendrier.Panel1
            // 
            this.splitCalendrier.Panel1.Controls.Add(this.lblCalDate);
            this.splitCalendrier.Panel1.Controls.Add(this.dataEntretienDate);
            // 
            // splitCalendrier.Panel2
            // 
            this.splitCalendrier.Panel2.Controls.Add(this.lblCalKm);
            this.splitCalendrier.Panel2.Controls.Add(this.dataEntretienKm);
            this.splitCalendrier.Size = new System.Drawing.Size(909, 300);
            this.splitCalendrier.SplitterDistance = 458;
            this.splitCalendrier.TabIndex = 0;
            // 
            // lblCalDate
            // 
            this.lblCalDate.AutoSize = true;
            this.lblCalDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalDate.Location = new System.Drawing.Point(0, 0);
            this.lblCalDate.Name = "lblCalDate";
            this.lblCalDate.Size = new System.Drawing.Size(134, 13);
            this.lblCalDate.TabIndex = 1;
            this.lblCalDate.Text = "Entretien à venir (par Date)";
            // 
            // dataEntretienDate
            // 
            this.dataEntretienDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntretienDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataEntretienDate.Location = new System.Drawing.Point(0, 28);
            this.dataEntretienDate.Name = "dataEntretienDate";
            this.dataEntretienDate.Size = new System.Drawing.Size(458, 272);
            this.dataEntretienDate.TabIndex = 0;
            // 
            // lblCalKm
            // 
            this.lblCalKm.AutoSize = true;
            this.lblCalKm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalKm.Location = new System.Drawing.Point(0, 0);
            this.lblCalKm.Name = "lblCalKm";
            this.lblCalKm.Size = new System.Drawing.Size(165, 13);
            this.lblCalKm.TabIndex = 1;
            this.lblCalKm.Text = "Entretien à venir (par kilométrage)";
            // 
            // dataEntretienKm
            // 
            this.dataEntretienKm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntretienKm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataEntretienKm.Location = new System.Drawing.Point(0, 28);
            this.dataEntretienKm.Name = "dataEntretienKm";
            this.dataEntretienKm.Size = new System.Drawing.Size(447, 272);
            this.dataEntretienKm.TabIndex = 0;
            // 
            // splitSaisieEntretien
            // 
            this.splitSaisieEntretien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitSaisieEntretien.Location = new System.Drawing.Point(0, 3);
            this.splitSaisieEntretien.Name = "splitSaisieEntretien";
            // 
            // splitSaisieEntretien.Panel1
            // 
            this.splitSaisieEntretien.Panel1.Controls.Add(this.gbNouvelEntretien);
            this.splitSaisieEntretien.Panel1.Controls.Add(this.btnSaisirEntretien);
            // 
            // splitSaisieEntretien.Panel2
            // 
            this.splitSaisieEntretien.Panel2.Controls.Add(this.dataHistEntretien);
            this.splitSaisieEntretien.Panel2.Controls.Add(this.lblEntretienPasse);
            this.splitSaisieEntretien.Size = new System.Drawing.Size(909, 407);
            this.splitSaisieEntretien.SplitterDistance = 441;
            this.splitSaisieEntretien.TabIndex = 17;
            // 
            // gbNouvelEntretien
            // 
            this.gbNouvelEntretien.Controls.Add(this.lblErreur);
            this.gbNouvelEntretien.Controls.Add(this.cbLstEntretiens);
            this.gbNouvelEntretien.Controls.Add(this.btnAnnulerEntretien);
            this.gbNouvelEntretien.Controls.Add(this.lblGarage);
            this.gbNouvelEntretien.Controls.Add(this.lblCommentaire);
            this.gbNouvelEntretien.Controls.Add(this.btnEnregistrerEntretien);
            this.gbNouvelEntretien.Controls.Add(this.cbLstGarages);
            this.gbNouvelEntretien.Controls.Add(this.lblMontant);
            this.gbNouvelEntretien.Controls.Add(this.lblNmPiece);
            this.gbNouvelEntretien.Controls.Add(this.txtCommentaireEntretien);
            this.gbNouvelEntretien.Controls.Add(this.datePickerDtEntretien);
            this.gbNouvelEntretien.Controls.Add(this.lblEntretienFait);
            this.gbNouvelEntretien.Controls.Add(this.lblKmEntretien);
            this.gbNouvelEntretien.Controls.Add(this.txtNomPiece);
            this.gbNouvelEntretien.Controls.Add(this.txtMtEntretien);
            this.gbNouvelEntretien.Controls.Add(this.lblDateEntretien);
            this.gbNouvelEntretien.Controls.Add(this.txtKilometrageEntretien);
            this.gbNouvelEntretien.Location = new System.Drawing.Point(19, 56);
            this.gbNouvelEntretien.Name = "gbNouvelEntretien";
            this.gbNouvelEntretien.Size = new System.Drawing.Size(392, 302);
            this.gbNouvelEntretien.TabIndex = 34;
            this.gbNouvelEntretien.TabStop = false;
            this.gbNouvelEntretien.Visible = false;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(6, 243);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 51;
            // 
            // cbLstEntretiens
            // 
            this.cbLstEntretiens.FormattingEnabled = true;
            this.cbLstEntretiens.Location = new System.Drawing.Point(180, 13);
            this.cbLstEntretiens.Name = "cbLstEntretiens";
            this.cbLstEntretiens.Size = new System.Drawing.Size(184, 21);
            this.cbLstEntretiens.TabIndex = 50;
            // 
            // btnAnnulerEntretien
            // 
            this.btnAnnulerEntretien.Location = new System.Drawing.Point(195, 273);
            this.btnAnnulerEntretien.Name = "btnAnnulerEntretien";
            this.btnAnnulerEntretien.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerEntretien.TabIndex = 49;
            this.btnAnnulerEntretien.Text = "Annuler";
            this.btnAnnulerEntretien.UseVisualStyleBackColor = true;
            // 
            // lblGarage
            // 
            this.lblGarage.AutoSize = true;
            this.lblGarage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGarage.Location = new System.Drawing.Point(126, 49);
            this.lblGarage.Name = "lblGarage";
            this.lblGarage.Size = new System.Drawing.Size(48, 13);
            this.lblGarage.TabIndex = 34;
            this.lblGarage.Text = "Garage :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(97, 210);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(77, 13);
            this.lblCommentaire.TabIndex = 40;
            this.lblCommentaire.Text = "Commentaire : ";
            // 
            // btnEnregistrerEntretien
            // 
            this.btnEnregistrerEntretien.Location = new System.Drawing.Point(289, 273);
            this.btnEnregistrerEntretien.Name = "btnEnregistrerEntretien";
            this.btnEnregistrerEntretien.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerEntretien.TabIndex = 48;
            this.btnEnregistrerEntretien.Text = "Enregistrer";
            this.btnEnregistrerEntretien.UseVisualStyleBackColor = true;
            this.btnEnregistrerEntretien.Click += new System.EventHandler(this.btnEnregistrerEntretien_Click);
            // 
            // cbLstGarages
            // 
            this.cbLstGarages.FormattingEnabled = true;
            this.cbLstGarages.Location = new System.Drawing.Point(180, 46);
            this.cbLstGarages.Name = "cbLstGarages";
            this.cbLstGarages.Size = new System.Drawing.Size(184, 21);
            this.cbLstGarages.TabIndex = 42;
            this.cbLstGarages.SelectedIndexChanged += new System.EventHandler(this.cbLstGarages_SelectedIndexChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(119, 82);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(55, 13);
            this.lblMontant.TabIndex = 36;
            this.lblMontant.Text = "Montant : ";
            // 
            // lblNmPiece
            // 
            this.lblNmPiece.AutoSize = true;
            this.lblNmPiece.Location = new System.Drawing.Point(29, 178);
            this.lblNmPiece.Name = "lblNmPiece";
            this.lblNmPiece.Size = new System.Drawing.Size(145, 13);
            this.lblNmPiece.TabIndex = 39;
            this.lblNmPiece.Text = "Nom de la pièce remplacée : ";
            // 
            // txtCommentaireEntretien
            // 
            this.txtCommentaireEntretien.Location = new System.Drawing.Point(180, 207);
            this.txtCommentaireEntretien.Name = "txtCommentaireEntretien";
            this.txtCommentaireEntretien.Size = new System.Drawing.Size(184, 20);
            this.txtCommentaireEntretien.TabIndex = 47;
            // 
            // datePickerDtEntretien
            // 
            this.datePickerDtEntretien.Location = new System.Drawing.Point(180, 111);
            this.datePickerDtEntretien.Name = "datePickerDtEntretien";
            this.datePickerDtEntretien.Size = new System.Drawing.Size(184, 20);
            this.datePickerDtEntretien.TabIndex = 43;
            // 
            // lblEntretienFait
            // 
            this.lblEntretienFait.AutoSize = true;
            this.lblEntretienFait.Location = new System.Drawing.Point(119, 16);
            this.lblEntretienFait.Name = "lblEntretienFait";
            this.lblEntretienFait.Size = new System.Drawing.Size(55, 13);
            this.lblEntretienFait.TabIndex = 35;
            this.lblEntretienFait.Text = "Entretien :";
            // 
            // lblKmEntretien
            // 
            this.lblKmEntretien.AutoSize = true;
            this.lblKmEntretien.Location = new System.Drawing.Point(106, 146);
            this.lblKmEntretien.Name = "lblKmEntretien";
            this.lblKmEntretien.Size = new System.Drawing.Size(68, 13);
            this.lblKmEntretien.TabIndex = 38;
            this.lblKmEntretien.Text = "Kilométrage :";
            // 
            // txtNomPiece
            // 
            this.txtNomPiece.Location = new System.Drawing.Point(180, 175);
            this.txtNomPiece.Name = "txtNomPiece";
            this.txtNomPiece.Size = new System.Drawing.Size(184, 20);
            this.txtNomPiece.TabIndex = 46;
            // 
            // txtMtEntretien
            // 
            this.txtMtEntretien.Location = new System.Drawing.Point(180, 79);
            this.txtMtEntretien.Name = "txtMtEntretien";
            this.txtMtEntretien.Size = new System.Drawing.Size(184, 20);
            this.txtMtEntretien.TabIndex = 44;
            // 
            // lblDateEntretien
            // 
            this.lblDateEntretien.AutoSize = true;
            this.lblDateEntretien.Location = new System.Drawing.Point(135, 117);
            this.lblDateEntretien.Name = "lblDateEntretien";
            this.lblDateEntretien.Size = new System.Drawing.Size(39, 13);
            this.lblDateEntretien.TabIndex = 37;
            this.lblDateEntretien.Text = "Date : ";
            // 
            // txtKilometrageEntretien
            // 
            this.txtKilometrageEntretien.Location = new System.Drawing.Point(180, 143);
            this.txtKilometrageEntretien.Name = "txtKilometrageEntretien";
            this.txtKilometrageEntretien.Size = new System.Drawing.Size(184, 20);
            this.txtKilometrageEntretien.TabIndex = 45;
            // 
            // btnSaisirEntretien
            // 
            this.btnSaisirEntretien.Location = new System.Drawing.Point(19, 27);
            this.btnSaisirEntretien.Name = "btnSaisirEntretien";
            this.btnSaisirEntretien.Size = new System.Drawing.Size(172, 23);
            this.btnSaisirEntretien.TabIndex = 17;
            this.btnSaisirEntretien.Text = "Saisir un Entretien";
            this.btnSaisirEntretien.UseVisualStyleBackColor = true;
            this.btnSaisirEntretien.Click += new System.EventHandler(this.btnSaisirEntretien_Click);
            // 
            // dataHistEntretien
            // 
            this.dataHistEntretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistEntretien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataHistEntretien.Location = new System.Drawing.Point(0, 43);
            this.dataHistEntretien.Name = "dataHistEntretien";
            this.dataHistEntretien.Size = new System.Drawing.Size(464, 364);
            this.dataHistEntretien.TabIndex = 1;
            // 
            // lblEntretienPasse
            // 
            this.lblEntretienPasse.AutoSize = true;
            this.lblEntretienPasse.Location = new System.Drawing.Point(14, 12);
            this.lblEntretienPasse.Name = "lblEntretienPasse";
            this.lblEntretienPasse.Size = new System.Drawing.Size(129, 13);
            this.lblEntretienPasse.TabIndex = 0;
            this.lblEntretienPasse.Text = "Historique des entretiens :";
            // 
            // GestionEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 714);
            this.Controls.Add(this.splitGestionEntretien);
            this.Name = "GestionEntretien";
            this.Text = "CalendrierEntretien";
            this.splitGestionEntretien.Panel1.ResumeLayout(false);
            this.splitGestionEntretien.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGestionEntretien)).EndInit();
            this.splitGestionEntretien.ResumeLayout(false);
            this.splitCalendrier.Panel1.ResumeLayout(false);
            this.splitCalendrier.Panel1.PerformLayout();
            this.splitCalendrier.Panel2.ResumeLayout(false);
            this.splitCalendrier.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCalendrier)).EndInit();
            this.splitCalendrier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEntretienDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntretienKm)).EndInit();
            this.splitSaisieEntretien.Panel1.ResumeLayout(false);
            this.splitSaisieEntretien.Panel2.ResumeLayout(false);
            this.splitSaisieEntretien.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSaisieEntretien)).EndInit();
            this.splitSaisieEntretien.ResumeLayout(false);
            this.gbNouvelEntretien.ResumeLayout(false);
            this.gbNouvelEntretien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistEntretien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitGestionEntretien;
        private System.Windows.Forms.Label lblCalDate;
        private System.Windows.Forms.DataGridView dataEntretienDate;
        private System.Windows.Forms.Label lblCalKm;
        private System.Windows.Forms.DataGridView dataEntretienKm;
        private System.Windows.Forms.SplitContainer splitCalendrier;
        private System.Windows.Forms.SplitContainer splitSaisieEntretien;
        private System.Windows.Forms.DataGridView dataHistEntretien;
        private System.Windows.Forms.Label lblEntretienPasse;
        private System.Windows.Forms.Button btnSaisirEntretien;
        private System.Windows.Forms.GroupBox gbNouvelEntretien;
        private System.Windows.Forms.Button btnAnnulerEntretien;
        private System.Windows.Forms.Label lblGarage;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Button btnEnregistrerEntretien;
        private System.Windows.Forms.ComboBox cbLstGarages;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblNmPiece;
        private System.Windows.Forms.TextBox txtCommentaireEntretien;
        private System.Windows.Forms.DateTimePicker datePickerDtEntretien;
        private System.Windows.Forms.Label lblEntretienFait;
        private System.Windows.Forms.Label lblKmEntretien;
        private System.Windows.Forms.TextBox txtNomPiece;
        private System.Windows.Forms.TextBox txtMtEntretien;
        private System.Windows.Forms.Label lblDateEntretien;
        private System.Windows.Forms.TextBox txtKilometrageEntretien;
        private System.Windows.Forms.ComboBox cbLstEntretiens;
        private System.Windows.Forms.ToolTip tlTipPieceRemp;
        private System.Windows.Forms.Label lblErreur;
    }
}