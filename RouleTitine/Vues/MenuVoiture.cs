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
        private int numVoitAffiche;
        public MenuVoiture(Conducteur c)
        {
            InitializeComponent();
            this.conductConnecte = c;
            this.lblConducteur.Text = "Bonjour " + c._Prenom;
            this.lstVoiture = DALVoiture.getVoituresByConducteur(this.conductConnecte);
            if (this.lstVoiture.Count > 0)
            {
                numVoitAffiche = 0;
                this.afficherVoiture(this.lstVoiture[numVoitAffiche]);
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
                numVoitAffiche = 0;
                this.afficherVoiture(this.lstVoiture[numVoitAffiche]);
            }

           
        }

        private void afficherVoiture(Voiture voit)
        {
            if (voit._Image.Length > 1)
            {
                this.imgVoiture.Image = Program.byteArrayToImage(voit._Image);
            }
            else
            {
                this.imgVoiture.Image = null;
            }
            this.valueImmat.Text = voit._Immatriculation.ToString();
            this.valueKm.Text = voit._Kilometrage.ToString();
            this.valueDtAchat.Text = voit._DateAchat.ToShortDateString();
            this.valueDtMiseCircu.Text = voit._DateMiseEnCirculation.ToShortDateString();
            this.valueDtVente.Text = voit._DateVente.ToShortDateString();
            this.valueModele.Text = voit._Modele._Marque._Nom + " " + voit._Modele._Nom;
            this.valueCarb.Text = voit._Carburant._Nom;
            if (voit._DateVente.CompareTo(DateTime.MinValue)>0)
            {
                this.btnVendre.Visible = false;
                this.btnOperation.Enabled = false;
                this.btnAssurance.Enabled = false;
            }
            else
            {
                this.btnVendre.Visible = true;
                this.btnOperation.Enabled = true;
                this.btnAssurance.Enabled = true;
            }
        }

        private void btnVoitPrec_Click(object sender, EventArgs e)
        {
            numVoitAffiche -= 1;
            if (numVoitAffiche >= 0)
            {
                this.afficherVoiture(this.lstVoiture[numVoitAffiche]);
            }
            else
            {
                numVoitAffiche = 0;
            }
        }

        private void btnVoitSuiv_Click(object sender, EventArgs e)
        {
            numVoitAffiche += 1;
            if (numVoitAffiche < this.lstVoiture.Count)
            {
                this.afficherVoiture(this.lstVoiture[numVoitAffiche]);
            }
            else
            {
                numVoitAffiche = this.lstVoiture.Count - 1;
            }
        }

        private void btnVendre_Click(object sender, EventArgs e)
        {
            Vente dgVente = new Vente(this.lstVoiture[numVoitAffiche]);
            DialogResult dialog = dgVente.ShowDialog();
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                this.lstVoiture[numVoitAffiche] = DALVoiture.getVoitureByImmatriculation(this.lstVoiture[numVoitAffiche]._Immatriculation);
                numVoitAffiche = 0;
                this.afficherVoiture(this.lstVoiture[numVoitAffiche]);
            }
        }

        private void btnEntretien_Click(object sender, EventArgs e)
        {
            GestionEntretien gestionEntretien = new GestionEntretien(this.lstVoiture[numVoitAffiche]);
            gestionEntretien.ShowDialog();            
        }
    }
}
