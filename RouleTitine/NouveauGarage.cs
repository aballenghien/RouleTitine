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
    public partial class NouveauGarage : Form
    {
        public NouveauGarage()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int saisieOK = this.ControleSaisieUser();
            switch (saisieOK)
            {
                case 0:
                    this.lblErreur.Text = "";
                    Garage g = new Garage();
                    g._Nom = this.txtNom.Text;
                    g._Adresse = this.txtAdresse.Text;
                    g._CodePostal = this.txtCodePostal.Text;
                    g._Ville = this.txtVille.Text;
                    g._Telephone = this.txtTel.Text;
                    long garOK = DALGarage.insert(g);
                    if (garOK > -1)
                    {
                        MessageBox.Show("Nouveau garage enregistré");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement");
                        this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                        this.Close();
                    }
                    break;
                case 1:
                    this.lblErreur.Text = "Le garage doit avoir un nom";
                    break;
                case 2:
                    this.lblErreur.Text = "Le garage doit avoir une adresse";
                    break;
                case 3:
                    this.lblErreur.Text = "Le garage doit voir un code postal";
                    break;
                case 4:
                    this.lblErreur.Text = "Le garage doit avoir une ville";
                    break;
                case 5:
                    this.lblErreur.Text = "Le garage doit avoir un numéro de téléphone";
                    break;
            }
        }

        private int ControleSaisieUser()
        {
            int controle = 0;
            if (this.txtNom.Text.Equals(""))
            {
                controle = 1;
            }
            if(controle == 0 &&
                this.txtAdresse.Text.Equals(""))
            {
                controle = 2;
            }

            if (controle == 0 &&
                this.txtCodePostal.Text.Equals(""))
            {
                controle = 3;
            }

            if (controle == 0 &&
                this.txtVille.Text.Equals(""))
            {
                controle = 4;
            }
            if (controle == 0 &&
                this.txtTel.Text.Equals(""))
            {
                controle = 5;
            }
            return controle;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }
    }
}
