namespace RouleTitine
{
    partial class MenuVoiture
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
            this.imgVoiture = new System.Windows.Forms.PictureBox();
            this.lblConducteur = new System.Windows.Forms.Label();
            this.btnEntretien = new System.Windows.Forms.Button();
            this.lblEntretien = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnAssurance = new System.Windows.Forms.Button();
            this.barreEtatVoiture = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.valueCarb = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.valueModele = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.valueDtVente = new System.Windows.Forms.Label();
            this.lblDtVente = new System.Windows.Forms.Label();
            this.valueDtAchat = new System.Windows.Forms.Label();
            this.lblDtAchat = new System.Windows.Forms.Label();
            this.valueDtMiseCircu = new System.Windows.Forms.Label();
            this.lblDtMiseCircu = new System.Windows.Forms.Label();
            this.valueKm = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblImmat = new System.Windows.Forms.Label();
            this.valueImmat = new System.Windows.Forms.Label();
            this.btnVoitSuiv = new System.Windows.Forms.Button();
            this.btnVoitPrec = new System.Windows.Forms.Button();
            this.btnVendre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoiture)).BeginInit();
            this.barreEtatVoiture.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgVoiture
            // 
            this.imgVoiture.Location = new System.Drawing.Point(430, 27);
            this.imgVoiture.Name = "imgVoiture";
            this.imgVoiture.Size = new System.Drawing.Size(201, 141);
            this.imgVoiture.TabIndex = 0;
            this.imgVoiture.TabStop = false;
            // 
            // lblConducteur
            // 
            this.lblConducteur.AutoSize = true;
            this.lblConducteur.Location = new System.Drawing.Point(12, 27);
            this.lblConducteur.Name = "lblConducteur";
            this.lblConducteur.Size = new System.Drawing.Size(0, 13);
            this.lblConducteur.TabIndex = 2;
            // 
            // btnEntretien
            // 
            this.btnEntretien.Location = new System.Drawing.Point(128, 144);
            this.btnEntretien.Name = "btnEntretien";
            this.btnEntretien.Size = new System.Drawing.Size(263, 23);
            this.btnEntretien.TabIndex = 3;
            this.btnEntretien.Text = "Gérer l\'entretien de la voiture";
            this.btnEntretien.UseVisualStyleBackColor = true;
            this.btnEntretien.Click += new System.EventHandler(this.btnEntretien_Click);
            // 
            // lblEntretien
            // 
            this.lblEntretien.AutoSize = true;
            this.lblEntretien.Location = new System.Drawing.Point(217, 111);
            this.lblEntretien.Name = "lblEntretien";
            this.lblEntretien.Size = new System.Drawing.Size(84, 13);
            this.lblEntretien.TabIndex = 4;
            this.lblEntretien.Text = "Entretien à venir";
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(128, 173);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(263, 23);
            this.btnOperation.TabIndex = 5;
            this.btnOperation.Text = "Saisir des opérations courantes";
            this.btnOperation.UseVisualStyleBackColor = true;
            // 
            // btnAssurance
            // 
            this.btnAssurance.Location = new System.Drawing.Point(128, 202);
            this.btnAssurance.Name = "btnAssurance";
            this.btnAssurance.Size = new System.Drawing.Size(263, 23);
            this.btnAssurance.TabIndex = 6;
            this.btnAssurance.Text = "Gérer le contrat d\'assurance";
            this.btnAssurance.UseVisualStyleBackColor = true;
            // 
            // barreEtatVoiture
            // 
            this.barreEtatVoiture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.barreEtatVoiture.Location = new System.Drawing.Point(0, 0);
            this.barreEtatVoiture.Name = "barreEtatVoiture";
            this.barreEtatVoiture.Size = new System.Drawing.Size(643, 24);
            this.barreEtatVoiture.TabIndex = 7;
            this.barreEtatVoiture.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneVoitureToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ajouterUneVoitureToolStripMenuItem1
            // 
            this.ajouterUneVoitureToolStripMenuItem1.Name = "ajouterUneVoitureToolStripMenuItem1";
            this.ajouterUneVoitureToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.ajouterUneVoitureToolStripMenuItem1.Text = "Ajouter une voiture";
            this.ajouterUneVoitureToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneVoitureToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.valueCarb, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCarb, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.valueModele, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblModele, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.valueDtVente, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDtVente, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.valueDtAchat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDtAchat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueDtMiseCircu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDtMiseCircu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueKm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblImmat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueImmat, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(430, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 315);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // valueCarb
            // 
            this.valueCarb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueCarb.AutoSize = true;
            this.valueCarb.Location = new System.Drawing.Point(104, 265);
            this.valueCarb.Name = "valueCarb";
            this.valueCarb.Size = new System.Drawing.Size(93, 49);
            this.valueCarb.TabIndex = 13;
            this.valueCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarb
            // 
            this.lblCarb.AutoSize = true;
            this.lblCarb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarb.Location = new System.Drawing.Point(4, 265);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(93, 49);
            this.lblCarb.TabIndex = 12;
            this.lblCarb.Text = "Carburant";
            this.lblCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueModele
            // 
            this.valueModele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueModele.AutoSize = true;
            this.valueModele.Location = new System.Drawing.Point(104, 221);
            this.valueModele.Name = "valueModele";
            this.valueModele.Size = new System.Drawing.Size(93, 43);
            this.valueModele.TabIndex = 11;
            this.valueModele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModele.Location = new System.Drawing.Point(4, 221);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(93, 43);
            this.lblModele.TabIndex = 10;
            this.lblModele.Text = "Modèle";
            this.lblModele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDtVente
            // 
            this.valueDtVente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueDtVente.AutoSize = true;
            this.valueDtVente.Location = new System.Drawing.Point(104, 177);
            this.valueDtVente.Name = "valueDtVente";
            this.valueDtVente.Size = new System.Drawing.Size(93, 43);
            this.valueDtVente.TabIndex = 9;
            this.valueDtVente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDtVente
            // 
            this.lblDtVente.AutoSize = true;
            this.lblDtVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDtVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtVente.Location = new System.Drawing.Point(4, 177);
            this.lblDtVente.Name = "lblDtVente";
            this.lblDtVente.Size = new System.Drawing.Size(93, 43);
            this.lblDtVente.TabIndex = 8;
            this.lblDtVente.Text = "Date de vente";
            this.lblDtVente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDtAchat
            // 
            this.valueDtAchat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueDtAchat.AutoSize = true;
            this.valueDtAchat.Location = new System.Drawing.Point(104, 133);
            this.valueDtAchat.Name = "valueDtAchat";
            this.valueDtAchat.Size = new System.Drawing.Size(93, 43);
            this.valueDtAchat.TabIndex = 7;
            this.valueDtAchat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDtAchat
            // 
            this.lblDtAchat.AutoSize = true;
            this.lblDtAchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDtAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAchat.Location = new System.Drawing.Point(4, 133);
            this.lblDtAchat.Name = "lblDtAchat";
            this.lblDtAchat.Size = new System.Drawing.Size(93, 43);
            this.lblDtAchat.TabIndex = 6;
            this.lblDtAchat.Text = "Date d\'achat";
            this.lblDtAchat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDtMiseCircu
            // 
            this.valueDtMiseCircu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueDtMiseCircu.AutoSize = true;
            this.valueDtMiseCircu.Location = new System.Drawing.Point(104, 89);
            this.valueDtMiseCircu.Name = "valueDtMiseCircu";
            this.valueDtMiseCircu.Size = new System.Drawing.Size(93, 43);
            this.valueDtMiseCircu.TabIndex = 5;
            this.valueDtMiseCircu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDtMiseCircu
            // 
            this.lblDtMiseCircu.AutoSize = true;
            this.lblDtMiseCircu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDtMiseCircu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtMiseCircu.Location = new System.Drawing.Point(4, 89);
            this.lblDtMiseCircu.Name = "lblDtMiseCircu";
            this.lblDtMiseCircu.Size = new System.Drawing.Size(93, 43);
            this.lblDtMiseCircu.TabIndex = 4;
            this.lblDtMiseCircu.Text = "Date de mise en circulation";
            this.lblDtMiseCircu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueKm
            // 
            this.valueKm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueKm.AutoSize = true;
            this.valueKm.Location = new System.Drawing.Point(104, 45);
            this.valueKm.Name = "valueKm";
            this.valueKm.Size = new System.Drawing.Size(93, 43);
            this.valueKm.TabIndex = 3;
            this.valueKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(4, 45);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(93, 43);
            this.lblKm.TabIndex = 2;
            this.lblKm.Text = "Kilométrage";
            this.lblKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmat.Location = new System.Drawing.Point(4, 1);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(93, 43);
            this.lblImmat.TabIndex = 0;
            this.lblImmat.Text = "Immatriculation";
            this.lblImmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueImmat
            // 
            this.valueImmat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueImmat.AutoSize = true;
            this.valueImmat.Location = new System.Drawing.Point(104, 1);
            this.valueImmat.Name = "valueImmat";
            this.valueImmat.Size = new System.Drawing.Size(93, 43);
            this.valueImmat.TabIndex = 1;
            this.valueImmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoitSuiv
            // 
            this.btnVoitSuiv.Location = new System.Drawing.Point(603, 490);
            this.btnVoitSuiv.Name = "btnVoitSuiv";
            this.btnVoitSuiv.Size = new System.Drawing.Size(28, 23);
            this.btnVoitSuiv.TabIndex = 9;
            this.btnVoitSuiv.Text = ">";
            this.btnVoitSuiv.UseVisualStyleBackColor = true;
            this.btnVoitSuiv.Click += new System.EventHandler(this.btnVoitSuiv_Click);
            // 
            // btnVoitPrec
            // 
            this.btnVoitPrec.Location = new System.Drawing.Point(430, 490);
            this.btnVoitPrec.Name = "btnVoitPrec";
            this.btnVoitPrec.Size = new System.Drawing.Size(28, 23);
            this.btnVoitPrec.TabIndex = 10;
            this.btnVoitPrec.Text = "<";
            this.btnVoitPrec.UseVisualStyleBackColor = true;
            this.btnVoitPrec.Click += new System.EventHandler(this.btnVoitPrec_Click);
            // 
            // btnVendre
            // 
            this.btnVendre.Location = new System.Drawing.Point(465, 490);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(132, 23);
            this.btnVendre.TabIndex = 11;
            this.btnVendre.Text = "Vendre la voiture";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // MenuVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 520);
            this.Controls.Add(this.btnVendre);
            this.Controls.Add(this.btnVoitPrec);
            this.Controls.Add(this.btnVoitSuiv);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAssurance);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblEntretien);
            this.Controls.Add(this.btnEntretien);
            this.Controls.Add(this.lblConducteur);
            this.Controls.Add(this.imgVoiture);
            this.Controls.Add(this.barreEtatVoiture);
            this.MainMenuStrip = this.barreEtatVoiture;
            this.Name = "MenuVoiture";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.imgVoiture)).EndInit();
            this.barreEtatVoiture.ResumeLayout(false);
            this.barreEtatVoiture.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVoiture;
        private System.Windows.Forms.Label lblConducteur;
        private System.Windows.Forms.Button btnEntretien;
        private System.Windows.Forms.Label lblEntretien;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnAssurance;
        private System.Windows.Forms.MenuStrip barreEtatVoiture;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label valueKm;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.Label valueImmat;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label valueDtVente;
        private System.Windows.Forms.Label lblDtVente;
        private System.Windows.Forms.Label valueDtAchat;
        private System.Windows.Forms.Label lblDtAchat;
        private System.Windows.Forms.Label valueDtMiseCircu;
        private System.Windows.Forms.Label lblDtMiseCircu;
        private System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label valueModele;
        private System.Windows.Forms.Button btnVoitSuiv;
        private System.Windows.Forms.Button btnVoitPrec;
        private System.Windows.Forms.Label valueCarb;
        private System.Windows.Forms.Button btnVendre;

    }
}