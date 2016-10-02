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
    
    public partial class MenuVoiture : Form
    {
        private Conducteur conductConnecte;
        private List<Voiture> lstVoiture;
        public MenuVoiture(Conducteur c)
        {
            InitializeComponent();
            this.conductConnecte = c;
            this.lblConducteur.Text = "Bonjour " + c._Prenom;
            this.lstVoiture = DALVoiture.getVoituresByConducteur(this.conductConnecte);
            if (this.lstVoiture.Count > 0)
            {
                this.afficherVoiture(this.lstVoiture[0]);
            }
        }

        private void ajouterUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Marque> lstMarques = DALMarque.getAllMarques();
            List<Carburant> lstcarb = DALCarburant.getAllCarburant();
            NouvelleVoiture newV = new NouvelleVoiture(lstMarques, lstcarb, this.conductConnecte);
            DialogResult dialog =  newV.ShowDialog();
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                this.lstVoiture = DALVoiture.getVoituresByConducteur(this.conductConnecte);
                this.afficherVoiture(this.lstVoiture[this.lstVoiture.Count-1]);
            }

           
        }

        private void afficherVoiture(Voiture voit)
        {
            this.imgVoiture.Image = Program.byteArrayToImage(voit._Image);
            this.valueImmat.Text = voit._Immatriculation.ToString();
            this.valueKm.Text = voit._Kilometrage.ToString();
            this.valueDtAchat.Text = voit._DateAchat.ToShortDateString();
            this.valueDtMiseCircu.Text = voit._DateMiseEnCirculation.ToShortDateString();
            this.valueDtVente.Text = voit._DateVente.ToShortDateString();
            this.valueModele.Text = voit._Modele._Marque._Nom + " " + voit._Modele._Nom;
            this.valueCarb.Text = voit._Carburant._Nom;
        }
    }
}
