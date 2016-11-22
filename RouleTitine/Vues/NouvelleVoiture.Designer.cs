namespace RouleTitine
{
    partial class NouvelleVoiture
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
            this.imgNouvelleVoiture = new System.Windows.Forms.PictureBox();
            this.lstCarburant = new System.Windows.Forms.ComboBox();
            this.lstMarque = new System.Windows.Forms.ComboBox();
            this.lstModele = new System.Windows.Forms.ComboBox();
            this.dtPickDateMiseEnCircu = new System.Windows.Forms.DateTimePicker();
            this.dtPickDateAchat = new System.Windows.Forms.DateTimePicker();
            this.lblImmatriculation = new System.Windows.Forms.Label();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lblDtMiseEnCircu = new System.Windows.Forms.Label();
            this.lblDateAchat = new System.Windows.Forms.Label();
            this.lblVolReserv = new System.Windows.Forms.Label();
            this.lblCarburant = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.btnEnrVoiture = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtCarburant = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.btnOkMarque = new System.Windows.Forms.Button();
            this.btnOkCarburant = new System.Windows.Forms.Button();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.txtImmatriculation = new System.Windows.Forms.MaskedTextBox();
            this.toolTipImmat = new System.Windows.Forms.ToolTip(this.components);
            this.txtKilometrage = new System.Windows.Forms.MaskedTextBox();
            this.toolTipKm = new System.Windows.Forms.ToolTip(this.components);
            this.txtVolReserv = new System.Windows.Forms.MaskedTextBox();
            this.toolTipVolReserv = new System.Windows.Forms.ToolTip(this.components);
            this.lblErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNouvelleVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNouvelleVoiture
            // 
            this.imgNouvelleVoiture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgNouvelleVoiture.Location = new System.Drawing.Point(422, 12);
            this.imgNouvelleVoiture.Name = "imgNouvelleVoiture";
            this.imgNouvelleVoiture.Size = new System.Drawing.Size(214, 109);
            this.imgNouvelleVoiture.TabIndex = 1;
            this.imgNouvelleVoiture.TabStop = false;
            // 
            // lstCarburant
            // 
            this.lstCarburant.FormattingEnabled = true;
            this.lstCarburant.Location = new System.Drawing.Point(155, 294);
            this.lstCarburant.Name = "lstCarburant";
            this.lstCarburant.Size = new System.Drawing.Size(226, 21);
            this.lstCarburant.TabIndex = 5;
            this.lstCarburant.SelectionChangeCommitted += new System.EventHandler(this.lstCarburant_SelectionChangeCommitted);
            // 
            // lstMarque
            // 
            this.lstMarque.FormattingEnabled = true;
            this.lstMarque.Location = new System.Drawing.Point(155, 324);
            this.lstMarque.Name = "lstMarque";
            this.lstMarque.Size = new System.Drawing.Size(226, 21);
            this.lstMarque.TabIndex = 8;
            this.lstMarque.SelectedIndexChanged += new System.EventHandler(this.lstMarque_SelectedIndexChanged);
            // 
            // lstModele
            // 
            this.lstModele.Enabled = false;
            this.lstModele.FormattingEnabled = true;
            this.lstModele.Location = new System.Drawing.Point(155, 354);
            this.lstModele.Name = "lstModele";
            this.lstModele.Size = new System.Drawing.Size(226, 21);
            this.lstModele.TabIndex = 11;
            this.lstModele.SelectionChangeCommitted += new System.EventHandler(this.lstModele_SelectionChangeCommitted);
            // 
            // dtPickDateMiseEnCircu
            // 
            this.dtPickDateMiseEnCircu.Location = new System.Drawing.Point(155, 207);
            this.dtPickDateMiseEnCircu.Name = "dtPickDateMiseEnCircu";
            this.dtPickDateMiseEnCircu.Size = new System.Drawing.Size(226, 20);
            this.dtPickDateMiseEnCircu.TabIndex = 2;
            // 
            // dtPickDateAchat
            // 
            this.dtPickDateAchat.Location = new System.Drawing.Point(155, 236);
            this.dtPickDateAchat.Name = "dtPickDateAchat";
            this.dtPickDateAchat.Size = new System.Drawing.Size(226, 20);
            this.dtPickDateAchat.TabIndex = 3;
            // 
            // lblImmatriculation
            // 
            this.lblImmatriculation.AutoSize = true;
            this.lblImmatriculation.Location = new System.Drawing.Point(60, 152);
            this.lblImmatriculation.Name = "lblImmatriculation";
            this.lblImmatriculation.Size = new System.Drawing.Size(89, 13);
            this.lblImmatriculation.TabIndex = 15;
            this.lblImmatriculation.Text = "Immatricultation : ";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Location = new System.Drawing.Point(78, 181);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(71, 13);
            this.lblKilometrage.TabIndex = 16;
            this.lblKilometrage.Text = "Kilométrage : ";
            // 
            // lblDtMiseEnCircu
            // 
            this.lblDtMiseEnCircu.AutoSize = true;
            this.lblDtMiseEnCircu.Location = new System.Drawing.Point(5, 213);
            this.lblDtMiseEnCircu.Name = "lblDtMiseEnCircu";
            this.lblDtMiseEnCircu.Size = new System.Drawing.Size(144, 13);
            this.lblDtMiseEnCircu.TabIndex = 17;
            this.lblDtMiseEnCircu.Text = "Date de mise en circulation : ";
            // 
            // lblDateAchat
            // 
            this.lblDateAchat.AutoSize = true;
            this.lblDateAchat.Location = new System.Drawing.Point(72, 236);
            this.lblDateAchat.Name = "lblDateAchat";
            this.lblDateAchat.Size = new System.Drawing.Size(77, 13);
            this.lblDateAchat.TabIndex = 18;
            this.lblDateAchat.Text = "Date d\'achat : ";
            // 
            // lblVolReserv
            // 
            this.lblVolReserv.AutoSize = true;
            this.lblVolReserv.Location = new System.Drawing.Point(40, 268);
            this.lblVolReserv.Name = "lblVolReserv";
            this.lblVolReserv.Size = new System.Drawing.Size(109, 13);
            this.lblVolReserv.TabIndex = 19;
            this.lblVolReserv.Text = "Volume du réservoir : ";
            // 
            // lblCarburant
            // 
            this.lblCarburant.AutoSize = true;
            this.lblCarburant.Location = new System.Drawing.Point(87, 297);
            this.lblCarburant.Name = "lblCarburant";
            this.lblCarburant.Size = new System.Drawing.Size(62, 13);
            this.lblCarburant.TabIndex = 20;
            this.lblCarburant.Text = "Carburant : ";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(97, 327);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(52, 13);
            this.lblMarque.TabIndex = 21;
            this.lblMarque.Text = "Marque : ";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(98, 357);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(51, 13);
            this.lblModele.TabIndex = 22;
            this.lblModele.Text = "Modèle : ";
            // 
            // btnEnrVoiture
            // 
            this.btnEnrVoiture.Location = new System.Drawing.Point(503, 426);
            this.btnEnrVoiture.Name = "btnEnrVoiture";
            this.btnEnrVoiture.Size = new System.Drawing.Size(75, 23);
            this.btnEnrVoiture.TabIndex = 12;
            this.btnEnrVoiture.Text = "Enregistrer";
            this.btnEnrVoiture.UseVisualStyleBackColor = true;
            this.btnEnrVoiture.Click += new System.EventHandler(this.btnEnrVoiture_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(422, 426);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtCarburant
            // 
            this.txtCarburant.Location = new System.Drawing.Point(387, 295);
            this.txtCarburant.Name = "txtCarburant";
            this.txtCarburant.Size = new System.Drawing.Size(100, 20);
            this.txtCarburant.TabIndex = 6;
            this.txtCarburant.Visible = false;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(387, 324);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(100, 20);
            this.txtMarque.TabIndex = 9;
            this.txtMarque.Visible = false;
            // 
            // btnOkMarque
            // 
            this.btnOkMarque.Location = new System.Drawing.Point(493, 321);
            this.btnOkMarque.Name = "btnOkMarque";
            this.btnOkMarque.Size = new System.Drawing.Size(32, 23);
            this.btnOkMarque.TabIndex = 10;
            this.btnOkMarque.Text = "OK";
            this.btnOkMarque.UseVisualStyleBackColor = true;
            this.btnOkMarque.Visible = false;
            this.btnOkMarque.Click += new System.EventHandler(this.btnOkMarque_Click);
            // 
            // btnOkCarburant
            // 
            this.btnOkCarburant.Location = new System.Drawing.Point(493, 295);
            this.btnOkCarburant.Name = "btnOkCarburant";
            this.btnOkCarburant.Size = new System.Drawing.Size(32, 23);
            this.btnOkCarburant.TabIndex = 7;
            this.btnOkCarburant.Text = "OK";
            this.btnOkCarburant.UseVisualStyleBackColor = true;
            this.btnOkCarburant.Visible = false;
            this.btnOkCarburant.Click += new System.EventHandler(this.btnOkCarburant_Click);
            // 
            // openPicture
            // 
            this.openPicture.FileName = "openFileDialog1";
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(422, 128);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImg.TabIndex = 14;
            this.btnOpenImg.Text = "Parcourir ...";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // txtImmatriculation
            // 
            this.txtImmatriculation.BeepOnError = true;
            this.txtImmatriculation.Location = new System.Drawing.Point(155, 149);
            this.txtImmatriculation.Mask = "AA-999-AA";
            this.txtImmatriculation.Name = "txtImmatriculation";
            this.txtImmatriculation.Size = new System.Drawing.Size(226, 20);
            this.txtImmatriculation.TabIndex = 0;
            this.txtImmatriculation.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtImmatriculation_MaskInputRejected);
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.BeepOnError = true;
            this.txtKilometrage.Location = new System.Drawing.Point(155, 178);
            this.txtKilometrage.Mask = "9999999";
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.Size = new System.Drawing.Size(226, 20);
            this.txtKilometrage.TabIndex = 1;
            this.txtKilometrage.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtKilometrage_MaskInputRejected);
            // 
            // txtVolReserv
            // 
            this.txtVolReserv.BeepOnError = true;
            this.txtVolReserv.Location = new System.Drawing.Point(155, 265);
            this.txtVolReserv.Mask = "999";
            this.txtVolReserv.Name = "txtVolReserv";
            this.txtVolReserv.Size = new System.Drawing.Size(226, 20);
            this.txtVolReserv.TabIndex = 4;
            this.txtVolReserv.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtVolReserv_MaskInputRejected);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(60, 108);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 30;
            // 
            // NouvelleVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 465);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.txtVolReserv);
            this.Controls.Add(this.txtKilometrage);
            this.Controls.Add(this.txtImmatriculation);
            this.Controls.Add(this.btnOpenImg);
            this.Controls.Add(this.btnOkCarburant);
            this.Controls.Add(this.btnOkMarque);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtCarburant);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnrVoiture);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCarburant);
            this.Controls.Add(this.lblVolReserv);
            this.Controls.Add(this.lblDateAchat);
            this.Controls.Add(this.lblDtMiseEnCircu);
            this.Controls.Add(this.lblKilometrage);
            this.Controls.Add(this.lblImmatriculation);
            this.Controls.Add(this.dtPickDateAchat);
            this.Controls.Add(this.dtPickDateMiseEnCircu);
            this.Controls.Add(this.lstModele);
            this.Controls.Add(this.lstMarque);
            this.Controls.Add(this.lstCarburant);
            this.Controls.Add(this.imgNouvelleVoiture);
            this.Name = "NouvelleVoiture";
            this.Text = "NouvelleVoiture";
            ((System.ComponentModel.ISupportInitialize)(this.imgNouvelleVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNouvelleVoiture;
        private System.Windows.Forms.ComboBox lstCarburant;
        private System.Windows.Forms.ComboBox lstMarque;
        private System.Windows.Forms.ComboBox lstModele;
        private System.Windows.Forms.DateTimePicker dtPickDateMiseEnCircu;
        private System.Windows.Forms.DateTimePicker dtPickDateAchat;
        private System.Windows.Forms.Label lblImmatriculation;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Label lblDtMiseEnCircu;
        private System.Windows.Forms.Label lblDateAchat;
        private System.Windows.Forms.Label lblVolReserv;
        private System.Windows.Forms.Label lblCarburant;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Button btnEnrVoiture;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtCarburant;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Button btnOkMarque;
        private System.Windows.Forms.Button btnOkCarburant;
        private System.Windows.Forms.OpenFileDialog openPicture;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.MaskedTextBox txtImmatriculation;
        private System.Windows.Forms.ToolTip toolTipImmat;
        private System.Windows.Forms.MaskedTextBox txtKilometrage;
        private System.Windows.Forms.ToolTip toolTipKm;
        private System.Windows.Forms.MaskedTextBox txtVolReserv;
        private System.Windows.Forms.ToolTip toolTipVolReserv;
        private System.Windows.Forms.Label lblErreur;
    }
}