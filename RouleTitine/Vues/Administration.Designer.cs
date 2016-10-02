namespace RouleTitine
{
    partial class Administration
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
            this.txtNomConducteur = new System.Windows.Forms.TextBox();
            this.lblNomConducteur = new System.Windows.Forms.Label();
            this.lblPrenomConducteur = new System.Windows.Forms.Label();
            this.txtPrenomConducteur = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiantf = new System.Windows.Forms.Label();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPwd1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.infoMail = new System.Windows.Forms.ToolTip(this.components);
            this.lblErreur = new System.Windows.Forms.Label();
            this.lblInfoMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomConducteur
            // 
            this.txtNomConducteur.Location = new System.Drawing.Point(200, 67);
            this.txtNomConducteur.Name = "txtNomConducteur";
            this.txtNomConducteur.Size = new System.Drawing.Size(177, 20);
            this.txtNomConducteur.TabIndex = 1;
            // 
            // lblNomConducteur
            // 
            this.lblNomConducteur.AutoSize = true;
            this.lblNomConducteur.Location = new System.Drawing.Point(156, 70);
            this.lblNomConducteur.Name = "lblNomConducteur";
            this.lblNomConducteur.Size = new System.Drawing.Size(38, 13);
            this.lblNomConducteur.TabIndex = 0;
            this.lblNomConducteur.Text = "Nom : ";
            // 
            // lblPrenomConducteur
            // 
            this.lblPrenomConducteur.AutoSize = true;
            this.lblPrenomConducteur.Location = new System.Drawing.Point(143, 108);
            this.lblPrenomConducteur.Name = "lblPrenomConducteur";
            this.lblPrenomConducteur.Size = new System.Drawing.Size(52, 13);
            this.lblPrenomConducteur.TabIndex = 2;
            this.lblPrenomConducteur.Text = "Prénom : ";
            // 
            // txtPrenomConducteur
            // 
            this.txtPrenomConducteur.Location = new System.Drawing.Point(201, 105);
            this.txtPrenomConducteur.Name = "txtPrenomConducteur";
            this.txtPrenomConducteur.Size = new System.Drawing.Size(177, 20);
            this.txtPrenomConducteur.TabIndex = 3;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(201, 143);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(177, 20);
            this.txtIdentifiant.TabIndex = 5;
            // 
            // lblIdentifiantf
            // 
            this.lblIdentifiantf.AutoSize = true;
            this.lblIdentifiantf.Location = new System.Drawing.Point(133, 146);
            this.lblIdentifiantf.Name = "lblIdentifiantf";
            this.lblIdentifiantf.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiantf.TabIndex = 4;
            this.lblIdentifiantf.Text = "Identifiant : ";
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(201, 219);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(177, 20);
            this.txtPwd1.TabIndex = 9;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(201, 257);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(177, 20);
            this.txtPwd2.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 181);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(177, 20);
            this.txtMail.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(111, 184);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(84, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Adresse e-mail : ";
            // 
            // lblPwd1
            // 
            this.lblPwd1.AutoSize = true;
            this.lblPwd1.Location = new System.Drawing.Point(115, 222);
            this.lblPwd1.Name = "lblPwd1";
            this.lblPwd1.Size = new System.Drawing.Size(80, 13);
            this.lblPwd1.TabIndex = 8;
            this.lblPwd1.Text = "Mot de passe : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Retapez votre mot de passe : ";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(445, 343);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(364, 343);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreur.Location = new System.Drawing.Point(49, 24);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 14;
            // 
            // lblInfoMail
            // 
            this.lblInfoMail.AutoSize = true;
            this.lblInfoMail.Location = new System.Drawing.Point(384, 184);
            this.lblInfoMail.Name = "lblInfoMail";
            this.lblInfoMail.Size = new System.Drawing.Size(19, 13);
            this.lblInfoMail.TabIndex = 15;
            this.lblInfoMail.Text = "??";
            this.lblInfoMail.MouseHover += new System.EventHandler(this.lblInfoMail_MouseHover);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 378);
            this.Controls.Add(this.lblInfoMail);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPwd1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.lblIdentifiantf);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtPrenomConducteur);
            this.Controls.Add(this.lblPrenomConducteur);
            this.Controls.Add(this.lblNomConducteur);
            this.Controls.Add(this.txtNomConducteur);
            this.Name = "Administration";
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomConducteur;
        private System.Windows.Forms.Label lblNomConducteur;
        private System.Windows.Forms.Label lblPrenomConducteur;
        private System.Windows.Forms.TextBox txtPrenomConducteur;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiantf;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ToolTip infoMail;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label lblInfoMail;
    }
}