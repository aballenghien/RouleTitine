namespace RouleTitine
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lnklblPwdOublie = new System.Windows.Forms.LinkLabel();
            this.lnklblInscription = new System.Windows.Forms.LinkLabel();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(115, 92);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 0;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(47, 95);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(115, 119);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(29, 122);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(80, 13);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Mot de passe : ";
            // 
            // lnklblPwdOublie
            // 
            this.lnklblPwdOublie.AutoSize = true;
            this.lnklblPwdOublie.Location = new System.Drawing.Point(115, 146);
            this.lnklblPwdOublie.Name = "lnklblPwdOublie";
            this.lnklblPwdOublie.Size = new System.Drawing.Size(142, 13);
            this.lnklblPwdOublie.TabIndex = 4;
            this.lnklblPwdOublie.TabStop = true;
            this.lnklblPwdOublie.Text = "J\'ai oublié mon mot de passe";
            // 
            // lnklblInscription
            // 
            this.lnklblInscription.AutoSize = true;
            this.lnklblInscription.Location = new System.Drawing.Point(112, 175);
            this.lnklblInscription.Name = "lnklblInscription";
            this.lnklblInscription.Size = new System.Drawing.Size(176, 13);
            this.lnklblInscription.TabIndex = 5;
            this.lnklblInscription.TabStop = true;
            this.lnklblInscription.Text = "C\'est la première fois que je viens ici";
            this.lnklblInscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblInscription_LinkClicked);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(212, 201);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lnklblInscription);
            this.Controls.Add(this.lnklblPwdOublie);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.LinkLabel lnklblPwdOublie;
        private System.Windows.Forms.LinkLabel lnklblInscription;
        private System.Windows.Forms.Button btnConnexion;
    }
}

