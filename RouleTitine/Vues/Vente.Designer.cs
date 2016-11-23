namespace RouleTitine
{
    partial class Vente
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
            this.dtPickerVente = new System.Windows.Forms.DateTimePicker();
            this.lblDtVente = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPickerVente
            // 
            this.dtPickerVente.Location = new System.Drawing.Point(108, 22);
            this.dtPickerVente.Name = "dtPickerVente";
            this.dtPickerVente.Size = new System.Drawing.Size(200, 20);
            this.dtPickerVente.TabIndex = 0;
            // 
            // lblDtVente
            // 
            this.lblDtVente.AutoSize = true;
            this.lblDtVente.Location = new System.Drawing.Point(21, 29);
            this.lblDtVente.Name = "lblDtVente";
            this.lblDtVente.Size = new System.Drawing.Size(81, 13);
            this.lblDtVente.TabIndex = 1;
            this.lblDtVente.Text = "Date de vente :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(353, 84);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(272, 84);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 119);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblDtVente);
            this.Controls.Add(this.dtPickerVente);
            this.Name = "Vente";
            this.Text = "Vente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerVente;
        private System.Windows.Forms.Label lblDtVente;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}