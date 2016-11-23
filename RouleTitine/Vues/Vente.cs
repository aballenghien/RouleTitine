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
    public partial class Vente : Form
    {

        Voiture voitAVendre;
        public Vente(Voiture voit)
        {
            InitializeComponent();
            this.voitAVendre = voit;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DateTime dtVente = this.dtPickerVente.Value;
            bool vendu = false;
            if(dtVente.CompareTo(DateTime.MinValue)>0
                && dtVente.Date.CompareTo(DateTime.Today.Date)<=0
                && dtVente.Date.CompareTo(voitAVendre._DateAchat.Date) > 0)
            {
                voitAVendre._DateVente = dtVente;
                DALVoiture.updateDateVente(voitAVendre);
                vendu = true;
            }
            if (vendu)
            {
                MessageBox.Show("La voiture est vendue");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("erreur lors de la saisie");
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            this.Close();
        }
    }
}
