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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void lnklblInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administration adm = new Administration();
            adm.Show();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Conducteur c = DALConducteur.getConducteurByIdentifiant(this.txtIdentifiant.Text);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(this.txtPwd.Text);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] pass = sha.ComputeHash(bytes);
            if (c._Password!=null && pass.SequenceEqual(c._Password))
            {
                MenuVoiture mnu = new MenuVoiture(c);
                mnu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("identifiant ou mot de passe incorrect");
            }
        }
    }
}
