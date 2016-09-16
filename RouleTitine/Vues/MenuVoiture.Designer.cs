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
            this.dataVoiture = new System.Windows.Forms.DataGridView();
            this.imgVoiture = new System.Windows.Forms.PictureBox();
            this.lblConducteur = new System.Windows.Forms.Label();
            this.btnEntretien = new System.Windows.Forms.Button();
            this.lblEntretien = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnAssurance = new System.Windows.Forms.Button();
            this.barreEtatVoiture = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoiture)).BeginInit();
            this.barreEtatVoiture.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataVoiture
            // 
            this.dataVoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoiture.Location = new System.Drawing.Point(468, 175);
            this.dataVoiture.Name = "dataVoiture";
            this.dataVoiture.Size = new System.Drawing.Size(163, 333);
            this.dataVoiture.TabIndex = 1;
            // 
            // imgVoiture
            // 
            this.imgVoiture.Location = new System.Drawing.Point(468, 27);
            this.imgVoiture.Name = "imgVoiture";
            this.imgVoiture.Size = new System.Drawing.Size(163, 141);
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
            // 
            // MenuVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 520);
            this.Controls.Add(this.btnAssurance);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblEntretien);
            this.Controls.Add(this.btnEntretien);
            this.Controls.Add(this.lblConducteur);
            this.Controls.Add(this.dataVoiture);
            this.Controls.Add(this.imgVoiture);
            this.Controls.Add(this.barreEtatVoiture);
            this.MainMenuStrip = this.barreEtatVoiture;
            this.Name = "MenuVoiture";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataVoiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoiture)).EndInit();
            this.barreEtatVoiture.ResumeLayout(false);
            this.barreEtatVoiture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVoiture;
        private System.Windows.Forms.PictureBox imgVoiture;
        private System.Windows.Forms.Label lblConducteur;
        private System.Windows.Forms.Button btnEntretien;
        private System.Windows.Forms.Label lblEntretien;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnAssurance;
        private System.Windows.Forms.MenuStrip barreEtatVoiture;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem1;

    }
}