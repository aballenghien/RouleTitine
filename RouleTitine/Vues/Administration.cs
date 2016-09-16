using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using GestionVoiture;

namespace RouleTitine
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int controle = ControlerChampsConducteur();
            bool enregistrement = false;

            switch (controle)
            {
                case 0:
                    Conducteur conducteur = new Conducteur();
                    conducteur._Nom = this.txtNomConducteur.Text;
                    conducteur._Prenom = this.txtPrenomConducteur.Text;
                    conducteur._Mail = this.txtMail.Text;
                    conducteur._Identifiant = this.txtIdentifiant.Text;
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(this.txtPwd1.Text);
                    SHA1 sha = new SHA1CryptoServiceProvider();
                    conducteur._Password = sha.ComputeHash(bytes);
                    enregistrement = Conducteur.EnregistrerNouveauConducteur(conducteur);
                    if (!enregistrement)
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'enregistrement");
                    }

            break;
                case 1:
                    this.lblErreur.Text = "Les deux mots de passes ne sont pas égaux";
                    enregistrement = false;
            break;
                case 2:
                    this.lblErreur.Text = "Adresse mail invalide";
                    enregistrement = false;
            break;
            }
            if (enregistrement)
            {
                MessageBox.Show("Vous pouvez maintenant nous connecter à l'application");
                this.Close();
            }
            

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int ControlerChampsConducteur()
        {
            int controle = 0;

            if (!(this.txtPwd1.Text.Equals(this.txtPwd2.Text)))
            {
                controle = 1;
            }

            if (!(this.txtMail.Text.Contains('@')))
            {
                controle = 2;
            }

            if (controle == 0)
            {
                int posArobase = this.txtMail.Text.IndexOf('@');
                if (!(this.txtMail.Text.LastIndexOf('.') > posArobase))
                {
                    controle = 2;
                }
            }

            return controle;
        }
    }
}
