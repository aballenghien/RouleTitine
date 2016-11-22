namespace RouleTitine
{
    partial class NouveauModele
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
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblEntretien = new System.Windows.Forms.Label();
            this.lblNomEntretien = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.txtNomEntretien = new System.Windows.Forms.TextBox();
            this.txtPeriodiciteKm = new System.Windows.Forms.NumericUpDown();
            this.btnNouvelEntretien = new System.Windows.Forms.Button();
            this.lblModele = new System.Windows.Forms.Label();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.btnEnregistrerModele = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.panelEntretien = new System.Windows.Forms.Panel();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtPeriodiciteMois = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodiciteKm)).BeginInit();
            this.panelEntretien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodiciteMois)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(18, 31);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(52, 13);
            this.lblMarque.TabIndex = 1;
            this.lblMarque.Text = "Marque : ";
            // 
            // lblEntretien
            // 
            this.lblEntretien.AutoSize = true;
            this.lblEntretien.Location = new System.Drawing.Point(18, 107);
            this.lblEntretien.Name = "lblEntretien";
            this.lblEntretien.Size = new System.Drawing.Size(108, 13);
            this.lblEntretien.TabIndex = 2;
            this.lblEntretien.Text = "Entretiens à réaliser : ";
            // 
            // lblNomEntretien
            // 
            this.lblNomEntretien.AutoSize = true;
            this.lblNomEntretien.Location = new System.Drawing.Point(18, 131);
            this.lblNomEntretien.Name = "lblNomEntretien";
            this.lblNomEntretien.Size = new System.Drawing.Size(38, 13);
            this.lblNomEntretien.TabIndex = 3;
            this.lblNomEntretien.Text = "Nom : ";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(124, 131);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(65, 13);
            this.lblPeriode.TabIndex = 4;
            this.lblPeriode.Text = "Périodicité : ";
            // 
            // txtNomEntretien
            // 
            this.txtNomEntretien.Location = new System.Drawing.Point(3, 3);
            this.txtNomEntretien.Name = "txtNomEntretien";
            this.txtNomEntretien.Size = new System.Drawing.Size(100, 20);
            this.txtNomEntretien.TabIndex = 6;
            // 
            // txtPeriodiciteKm
            // 
            this.txtPeriodiciteKm.Location = new System.Drawing.Point(109, 3);
            this.txtPeriodiciteKm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPeriodiciteKm.Name = "txtPeriodiciteKm";
            this.txtPeriodiciteKm.Size = new System.Drawing.Size(62, 20);
            this.txtPeriodiciteKm.TabIndex = 7;
            // 
            // btnNouvelEntretien
            // 
            this.btnNouvelEntretien.Location = new System.Drawing.Point(319, 4);
            this.btnNouvelEntretien.Name = "btnNouvelEntretien";
            this.btnNouvelEntretien.Size = new System.Drawing.Size(28, 20);
            this.btnNouvelEntretien.TabIndex = 9;
            this.btnNouvelEntretien.Text = "+";
            this.btnNouvelEntretien.UseVisualStyleBackColor = true;
            this.btnNouvelEntretien.Click += new System.EventHandler(this.btnNouvelEntretien_Click);
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(18, 69);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(91, 13);
            this.lblModele.TabIndex = 10;
            this.lblModele.Text = "Nom du Modèle : ";
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(112, 66);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(121, 20);
            this.txtModele.TabIndex = 11;
            // 
            // btnEnregistrerModele
            // 
            this.btnEnregistrerModele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerModele.Location = new System.Drawing.Point(313, 279);
            this.btnEnregistrerModele.Name = "btnEnregistrerModele";
            this.btnEnregistrerModele.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerModele.TabIndex = 12;
            this.btnEnregistrerModele.Text = "Enregistrer";
            this.btnEnregistrerModele.UseVisualStyleBackColor = true;
            this.btnEnregistrerModele.Click += new System.EventHandler(this.btnEnregistrerModele_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(232, 279);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(112, 28);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.ReadOnly = true;
            this.txtMarque.Size = new System.Drawing.Size(121, 20);
            this.txtMarque.TabIndex = 15;
            // 
            // panelEntretien
            // 
            this.panelEntretien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntretien.AutoScroll = true;
            this.panelEntretien.Controls.Add(this.lblMois);
            this.panelEntretien.Controls.Add(this.lblKm);
            this.panelEntretien.Controls.Add(this.txtPeriodiciteMois);
            this.panelEntretien.Controls.Add(this.txtNomEntretien);
            this.panelEntretien.Controls.Add(this.btnNouvelEntretien);
            this.panelEntretien.Controls.Add(this.txtPeriodiciteKm);
            this.panelEntretien.Location = new System.Drawing.Point(21, 147);
            this.panelEntretien.Name = "panelEntretien";
            this.panelEntretien.Size = new System.Drawing.Size(350, 126);
            this.panelEntretien.TabIndex = 16;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(280, 4);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(28, 13);
            this.lblMois.TabIndex = 12;
            this.lblMois.Text = "mois";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(178, 4);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(22, 13);
            this.lblKm.TabIndex = 11;
            this.lblKm.Text = "Km";
            // 
            // txtPeriodiciteMois
            // 
            this.txtPeriodiciteMois.Location = new System.Drawing.Point(211, 3);
            this.txtPeriodiciteMois.Name = "txtPeriodiciteMois";
            this.txtPeriodiciteMois.Size = new System.Drawing.Size(62, 20);
            this.txtPeriodiciteMois.TabIndex = 10;
            // 
            // NouveauModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 314);
            this.Controls.Add(this.panelEntretien);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrerModele);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.lblNomEntretien);
            this.Controls.Add(this.lblEntretien);
            this.Controls.Add(this.lblMarque);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 353);
            this.Name = "NouveauModele";
            this.Text = "NouveauModele";
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodiciteKm)).EndInit();
            this.panelEntretien.ResumeLayout(false);
            this.panelEntretien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodiciteMois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblEntretien;
        private System.Windows.Forms.Label lblNomEntretien;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.TextBox txtNomEntretien;
        private System.Windows.Forms.NumericUpDown txtPeriodiciteKm;
        private System.Windows.Forms.Button btnNouvelEntretien;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Button btnEnregistrerModele;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Panel panelEntretien;
        private System.Windows.Forms.NumericUpDown txtPeriodiciteMois;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.Label lblKm;
    }
}