using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionVoiture;

namespace RouleTitine
{
    public partial class NouveauModele : Form
    {
        // Liste permettant d'afficher plusieurs saisie d'entretien réguliers
        private List<TextBox> txtBoxesNomEntretien;
        private List<NumericUpDown> numPeriodesKm;
        private List<NumericUpDown> numPeriodesMois;
        private List<Label> lstLblKm;
        private List<Label> lstLblMois;
        private Button btnSupEntretien;
        private int nbEntretien;
        private Marque marque;
        public NouveauModele(Marque marque)
        {
            InitializeComponent();

            //renseignement de la marque
            this.marque = marque;
            txtMarque.Text = marque._Nom;
            
            //instanciation des listes
            txtBoxesNomEntretien = new List<TextBox>();
            numPeriodesMois = new List<NumericUpDown>();
            numPeriodesKm = new List<NumericUpDown>();
            lstLblKm = new List<Label>();
            lstLblMois = new List<Label>();

            //ajout des composants exsistants aux listes
            txtBoxesNomEntretien.Add(this.txtNomEntretien);
            numPeriodesKm.Add(this.txtPeriodiciteKm);
            numPeriodesMois.Add(this.txtPeriodiciteMois);
            lstLblKm.Add(this.lblKm);
            lstLblMois.Add(this.lblMois);
            nbEntretien = 0;

        }

        private void btnNouvelEntretien_Click(object sender, EventArgs e)
        {
            //TODO corriger le problème du bouton de suppression qui ne s'affiche pas
            // création d'une nouvelle ligne pour saisir un entretien
            this.nbEntretien += 1;
            this.panelEntretien.Controls.Remove(btnSupEntretien);
            TextBox txtEntretien = new TextBox();
            txtEntretien.Size = new System.Drawing.Size(100, 2);
            txtEntretien.Location = new System.Drawing.Point(this.txtNomEntretien.Location.X, this.txtNomEntretien.Location.Y+this.nbEntretien*26);
            NumericUpDown numUpDownKm = new NumericUpDown();
            numUpDownKm.Size = new System.Drawing.Size(62, 20);
            numUpDownKm.Location = new System.Drawing.Point(this.txtPeriodiciteKm.Location.X, this.txtPeriodiciteKm.Location.Y + this.nbEntretien * 26);
            NumericUpDown numUpDownMois = new NumericUpDown();
            numUpDownMois.Size = new System.Drawing.Size(62, 20);
            numUpDownMois.Location = new System.Drawing.Point(this.txtPeriodiciteMois.Location.X, this.txtPeriodiciteMois.Location.Y + this.nbEntretien * 26);
            Label labelKilometre = new Label();
            labelKilometre.Text = "Km";
            labelKilometre.Location = new System.Drawing.Point(this.lblKm.Location.X, this.lblKm.Location.Y + this.nbEntretien * 26);
            Label labelMois = new Label();
            labelMois.Text = "Mois";
            labelMois.Location = new System.Drawing.Point(this.lblMois.Location.X, this.lblMois.Location.Y + this.nbEntretien * 26);
            btnSupEntretien = new Button();
            btnSupEntretien.Text = "-";
            btnSupEntretien.Size = new System.Drawing.Size(28, 20); ;
            btnSupEntretien.Location = new System.Drawing.Point(this.btnNouvelEntretien.Location.X, this.btnNouvelEntretien.Location.Y + this.nbEntretien * 26);
            btnSupEntretien.Click += new System.EventHandler(this.btnSupEntretien_Click);
            this.panelEntretien.Controls.Add(txtEntretien);
            this.panelEntretien.Controls.Add(numUpDownKm);
            this.panelEntretien.Controls.Add(numUpDownMois);
            this.panelEntretien.Controls.Add(labelKilometre);
            this.panelEntretien.Controls.Add(labelMois);
            this.panelEntretien.Controls.Add(btnSupEntretien);
            this.txtBoxesNomEntretien.Add(txtEntretien);
            this.numPeriodesKm.Add(numUpDownKm);
            this.numPeriodesMois.Add(numUpDownMois);
            this.lstLblMois.Add(labelMois);
            this.lstLblKm.Add(labelKilometre);

                     

        }

        private void btnEnregistrerModele_Click(object sender, EventArgs e)
        {
            Modele mod = new Modele();
            if (!txtModele.Text.Equals("")) // Vérification saisie du nom du modèle
            {
                mod._Nom = txtModele.Text;
                mod._Marque = new Marque(txtMarque.Text);
                long modInsere = DALModele.insert(mod);
                if (modInsere >= 0)
                {
                    bool entIns = this.enregistrerEntretienAFaire(modInsere);
                    if (entIns)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                        this.Close();
                    }
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de la saisie");
                this.txtModele.Focus();
            }
            

        }

        private bool enregistrerEntretienAFaire(long mod)
        {
            bool resultat = true;
            for (int i = 0; i <= this.nbEntretien; i++)
            {
                if (resultat)
                {
                    EntretienAFaire ent = new EntretienAFaire();
                    EntretienRegulier entRegIns = enregistrerEntretienRegulier(i);
                    if (entRegIns._Id > 0)
                    {
                        ent._EntretienRegulier = entRegIns;
                        ent._Modele = DALModele.getModeleById(mod);
                        long result = DALEntretienAFaire.insert(ent);
                        if (result < 0)
                        {
                            resultat = false;
                        }
                    }
                    else
                    {
                        resultat = false;
                    }
                }

            }
            return resultat;
        }

        private EntretienRegulier enregistrerEntretienRegulier(int i)
        {
            EntretienRegulier entReg = new EntretienRegulier();
            bool ok = true;
            entReg._Kilometrage = (int)this.numPeriodesKm[i].Value;
            entReg._Periode = (int)this.numPeriodesMois[i].Value;           
            if (!this.txtBoxesNomEntretien[i].Text.Equals(""))
            {
                entReg._Nom = this.txtBoxesNomEntretien[i].Text;
                long entEnr = DALEntretienRegulier.insert(entReg);
                entReg._Id = entEnr;
            }
            else
            {
                MessageBox.Show("Erreur lors de la saisie");
                this.txtBoxesNomEntretien[i].Focus();
            }            
            return entReg;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }

        private void btnSupEntretien_Click(object sender, EventArgs e)
        {
            nbEntretien -= 1;
            // on récupère les éléments àsupprimer dans la liste
            TextBox entretien = this.txtBoxesNomEntretien.Last();
            NumericUpDown numKm = this.numPeriodesKm.Last();
            NumericUpDown numMois = this.numPeriodesMois.Last();
            Label km = this.lstLblKm.Last();
            Label mois = this.lstLblMois.Last();

            // on supprime les éléments de la fenêtre
            this.panelEntretien.Controls.Remove(entretien);
            this.panelEntretien.Controls.Remove(numKm);
            this.panelEntretien.Controls.Remove(numMois);
            this.panelEntretien.Controls.Remove(km);
            this.panelEntretien.Controls.Remove(mois);

            //On déplace le bouton sur le nouveau dernier élément
            this.panelEntretien.Controls.Remove(btnSupEntretien);
            btnSupEntretien = new Button();
            btnSupEntretien.Text = "-";
            btnSupEntretien.Size = new System.Drawing.Size(28, 20);
            btnSupEntretien.Location = new System.Drawing.Point(this.btnNouvelEntretien.Location.X, this.btnNouvelEntretien.Location.Y + this.nbEntretien * 26);
            btnSupEntretien.Click += new System.EventHandler(this.btnSupEntretien_Click);
            this.panelEntretien.Controls.Add(btnSupEntretien);

        }
    }
}
