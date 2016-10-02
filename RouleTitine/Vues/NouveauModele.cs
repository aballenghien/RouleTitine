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
        private List<TextBox> txtBoxesNomEntretien;
        private List<ComboBox> cbUnite;
        private List<NumericUpDown> numPeriodes;
        private int nbEntretien;
        private Marque marque;
        public NouveauModele(Marque marque)
        {
            InitializeComponent();
            this.marque = marque;
            txtMarque.Text = marque._Nom;
            txtBoxesNomEntretien = new List<TextBox>();
            cbUnite = new List<ComboBox>();
            numPeriodes = new List<NumericUpDown>();
            txtBoxesNomEntretien.Add(this.txtNomEntretien);
            cbUnite.Add(this.comboUnite);
            numPeriodes.Add(this.txtPeriodicite);
            nbEntretien = 0;
            this.comboUnite.Items.Add("--");
            this.comboUnite.Items.Add("km");
            this.comboUnite.Items.Add("mois");
            this.comboUnite.SelectedIndex = 0;

        }

        private void btnNouvelEntretien_Click(object sender, EventArgs e)
        {
            this.nbEntretien += 1;
            TextBox txtEntretien = new TextBox();
            txtEntretien.Size = new System.Drawing.Size(100, 2);
            txtEntretien.Location = new System.Drawing.Point(this.txtNomEntretien.Location.X, this.txtNomEntretien.Location.Y+this.nbEntretien*26);
            NumericUpDown numUpDown = new NumericUpDown();
            numUpDown.Size = new System.Drawing.Size(62, 20);
            numUpDown.Location = new System.Drawing.Point(this.txtPeriodicite.Location.X, this.txtPeriodicite.Location.Y + this.nbEntretien * 26);
            ComboBox combo = new ComboBox();
            combo.Location = new System.Drawing.Point(this.comboUnite.Location.X, this.comboUnite.Location.Y + this.nbEntretien * 26);
            combo.Size = new System.Drawing.Size(121, 21);
            combo.Items.Add("--");
            combo.Items.Add("km");
            combo.Items.Add("mois");
            combo.SelectedIndex = 0;
            this.panelEntretien.Controls.Add(txtEntretien);
            this.panelEntretien.Controls.Add(numUpDown);
            this.panelEntretien.Controls.Add(combo);
            this.txtBoxesNomEntretien.Add(txtEntretien);
            this.cbUnite.Add(combo);
            this.numPeriodes.Add(numUpDown);         

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
            if (this.cbUnite[i].SelectedItem.ToString().Equals("km"))
            {
                entReg._Kilometrage = (int)this.numPeriodes[i].Value;
            }
            else
            {
                if (this.cbUnite[i].SelectedItem.ToString().Equals("mois"))
                {
                    entReg._Periode = (int)this.numPeriodes[i].Value;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la saisie");
                    this.cbUnite[i].Focus();
                    ok = false;
                }
            }

            if (ok)
            {
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
            }
            return entReg;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }
    }
}
