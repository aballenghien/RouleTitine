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
            this.lblUnite = new System.Windows.Forms.Label();
            this.txtNomEntretien = new System.Windows.Forms.TextBox();
            this.txtPeriodicite = new System.Windows.Forms.NumericUpDown();
            this.comboUnite = new System.Windows.Forms.ComboBox();
            this.btnNouvelEntretien = new System.Windows.Forms.Button();
            this.lblModele = new System.Windows.Forms.Label();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.btnEnregistrerModele = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.panelEntretien = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodicite)).BeginInit();
            this.panelEntretien.SuspendLayout();
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
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(195, 131);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(56, 13);
            this.lblUnite.TabIndex = 5;
            this.lblUnite.Text = "km/mois : ";
            // 
            // txtNomEntretien
            // 
            this.txtNomEntretien.Location = new System.Drawing.Point(3, 3);
            this.txtNomEntretien.Name = "txtNomEntretien";
            this.txtNomEntretien.Size = new System.Drawing.Size(100, 20);
            this.txtNomEntretien.TabIndex = 6;
            // 
            // txtPeriodicite
            // 
            this.txtPeriodicite.Location = new System.Drawing.Point(109, 3);
            this.txtPeriodicite.Name = "txtPeriodicite";
            this.txtPeriodicite.Size = new System.Drawing.Size(62, 20);
            this.txtPeriodicite.TabIndex = 7;
            // 
            // comboUnite
            // 
            this.comboUnite.FormattingEnabled = true;
            this.comboUnite.Location = new System.Drawing.Point(177, 3);
            this.comboUnite.Name = "comboUnite";
            this.comboUnite.Size = new System.Drawing.Size(121, 21);
            this.comboUnite.TabIndex = 8;
            // 
            // btnNouvelEntretien
            // 
            this.btnNouvelEntretien.Location = new System.Drawing.Point(304, 3);
            this.btnNouvelEntretien.Name = "btnNouvelEntretien";
            this.btnNouvelEntretien.Size = new System.Drawing.Size(28, 23);
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
            this.panelEntretien.Controls.Add(this.comboUnite);
            this.panelEntretien.Controls.Add(this.txtNomEntretien);
            this.panelEntretien.Controls.Add(this.btnNouvelEntretien);
            this.panelEntretien.Controls.Add(this.txtPeriodicite);
            this.panelEntretien.Location = new System.Drawing.Point(21, 147);
            this.panelEntretien.Name = "panelEntretien";
            this.panelEntretien.Size = new System.Drawing.Size(350, 126);
            this.panelEntretien.TabIndex = 16;
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
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.lblNomEntretien);
            this.Controls.Add(this.lblEntretien);
            this.Controls.Add(this.lblMarque);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 353);
            this.Name = "NouveauModele";
            this.Text = "NouveauModele";
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodicite)).EndInit();
            this.panelEntretien.ResumeLayout(false);
            this.panelEntretien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblEntretien;
        private System.Windows.Forms.Label lblNomEntretien;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.TextBox txtNomEntretien;
        private System.Windows.Forms.NumericUpDown txtPeriodicite;
        private System.Windows.Forms.ComboBox comboUnite;
        private System.Windows.Forms.Button btnNouvelEntretien;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.Button btnEnregistrerModele;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Panel panelEntretien;
    }
}