﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GestionVoiture;

namespace RouleTitine
{
    public partial class NouvelleVoiture : Form
    {
        private Conducteur conduct;
        public NouvelleVoiture(List<Marque> lstMarques, List<Carburant> lstCarb, Conducteur c)
        {
            InitializeComponent();
            this.lstMarque.Items.Add("--");
            this.lstMarque.Items.Add("Ajouter une marque");
            this.lstMarque.Items.AddRange(lstMarques.ToArray());
            this.lstCarburant.Items.Add("--");
            this.lstCarburant.Items.Add("Ajouter un carburant");
            this.lstCarburant.Items.AddRange(lstCarb.ToArray());
            this.lstCarburant.SelectedIndex = 0;
            this.lstMarque.SelectedIndex = 0;
            this.conduct = c;
        }

        private void lstMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMarque.SelectedIndex != 0 && !this.lstMarque.SelectedItem.ToString().Equals("Ajouter une marque"))
            {
                this.lstModele.Enabled = true;
                Marque marq = (Marque)this.lstMarque.SelectedItem;
                List<Modele> lstMod = DALModele.getModelesByMarque(marq);
                this.lstModele.Items.Clear();
                this.lstModele.Items.Add("--");
                this.lstModele.Items.Add("Ajouter un modèle");
                this.lstModele.Items.AddRange(lstMod.ToArray());
                this.lstModele.SelectedIndex = 0;
            }
            else
            {
                if (this.lstMarque.SelectedItem.ToString().Equals("Ajouter une marque"))
                {
                    this.txtMarque.Visible = true;
                    this.btnOkMarque.Visible = true;
                }
            }
            
        }

        private void lstCarburant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.lstCarburant.SelectedItem.ToString().Equals("Ajouter un carburant"))
            {
                this.txtCarburant.Visible = true;
                this.btnOkCarburant.Visible = true;
            }
        }

        private void btnOkMarque_Click(object sender, EventArgs e)
        {
            Marque marq = new Marque();
            marq._Nom = this.txtMarque.Text;
            bool marqueinsere = DALMarque.insert(marq);
            if (marqueinsere)
            {
                this.txtMarque.Visible = false;
                this.btnOkMarque.Visible = false;
                this.lstMarque.Items.Clear();
                this.lstMarque.Items.Add("--");
                List<Marque> lstM = DALMarque.getAllMarques();
                this.lstMarque.Items.AddRange(lstM.ToArray());
                this.lstMarque.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("La marque existe déjà");
            }
        }

        private void btnOkCarburant_Click(object sender, EventArgs e)
        {
            Carburant carb = new Carburant();
            carb._Nom = this.txtCarburant.Text;
            bool carbinsere = DALCarburant.insert(carb);
            if (carbinsere)
            {
                this.txtCarburant.Visible = false;
                this.btnOkCarburant.Visible = false;
                this.lstCarburant.Items.Clear();
                this.lstCarburant.Items.Add("--");
                List<Carburant> lstC = DALCarburant.getAllCarburant();
                this.lstCarburant.Items.AddRange(lstC.ToArray());
                this.lstCarburant.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Le carburant existe déjà");
            }
        }

        private void lstModele_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.lstModele.SelectedItem.ToString().Equals("Ajouter un modèle"))
            {
                NouveauModele nvMod = new NouveauModele((Marque)this.lstMarque.SelectedItem);
                DialogResult dr =  nvMod.ShowDialog();
                switch (dr)
                {
                    case System.Windows.Forms.DialogResult.OK:
                        this.lstModele.Items.Clear();
                        this.lstModele.Items.Add("--");
                        List<Modele> lstModeles = DALModele.getModelesByMarque((Marque)this.lstMarque.SelectedItem);
                        this.lstModele.Items.AddRange(lstModeles.ToArray());
                        this.lstModele.SelectedIndex = 0;
                        break;
                    case System.Windows.Forms.DialogResult.Abort:
                        MessageBox.Show("Une erreur est survenue lors de l'enregistrement du modèle");
                        break;
                }
            }
        }

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openPicture.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Stream fileImg = this.openPicture.OpenFile();
                Image imgVoiture = Image.FromStream(fileImg);
                this.imgNouvelleVoiture.Image = imgVoiture;
            }
        }

        private void btnEnrVoiture_Click(object sender, EventArgs e)
        {
            Voiture uneVoit = new Voiture();
            if(this.txtKilometrage.Text.Equals("") && (this.dtPickDateAchat.Value.CompareTo(this.dtPickDateMiseEnCircu.Value)==0))
            {
                this.txtKilometrage.Text="0";
            }

            int enrOK = this.controleSaisieVoiture();
            bool voitInsere = false;
            switch (enrOK)
            {
                case 0:
                    this.lblErreur.Text = "";
                    uneVoit._Carburant = (Carburant)this.lstCarburant.SelectedItem;
                    uneVoit._Conducteur = this.conduct;
                    uneVoit._DateAchat = this.dtPickDateAchat.Value;
                    uneVoit._DateMiseEnCirculation = this.dtPickDateMiseEnCircu.Value;
                    if (this.imgNouvelleVoiture != null && this.imgNouvelleVoiture.Image != null)
                    {
                        uneVoit._Image = Program.imageToByteArray(this.imgNouvelleVoiture.Image);
                    }
                    else
                    {
                        uneVoit._Image = new byte[1];
                    }
                    uneVoit._Immatriculation = this.txtImmatriculation.Text;
                    uneVoit._Kilometrage = Convert.ToInt32(this.txtKilometrage.Text);
                    uneVoit._Modele = (Modele)this.lstModele.SelectedItem;
                    uneVoit._VolumeReservoir = Convert.ToInt32(this.txtVolReserv.Text, 10);
                    voitInsere = DALVoiture.insert(uneVoit);
                    if (voitInsere)
                    {
                        MessageBox.Show("Enregistrement effectué");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement");
                        this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    }
                    this.Close();
                    break;
                case 1:
                    this.lblErreur.Text = "Veuillez indiquer le numéro d'immatriculation de la voiture";
                    break;
                case 2:
                    this.lblErreur.Text = "Veuillez indiquer le kilométrage de la voiture";
                    break;
                case 3:
                    this.lblErreur.Text = "Erreur dans la saisie des dates";
                    break;
                case 4:
                    this.lblErreur.Text = "Veuillez indiquer le carburant de la voiture";
                    break;
                case 5:
                    this.lblErreur.Text = "Veuillez indiquer le volume du réservoir de la voiture";
                    break;
                case 6:
                    this.lblErreur.Text = "Veuillez indiquer le modèle de la voiture";
                    break;
            }
            

           
          
            
           
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }

        private void txtImmatriculation_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.toolTipImmat.ToolTipTitle = "Immatriculation incorrect";
            toolTipImmat.Show("Erreur dans le format de l'immatriculation", txtImmatriculation, txtImmatriculation.Location, 5000);
        }

        private void txtKilometrage_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.toolTipKm.ToolTipTitle = "Erreur saisie";
            toolTipKm.Show("Ne doit contenir que des chiffres", NouvelleVoiture.ActiveForm, txtKilometrage.Location, 5000);

        }

        private void txtVolReserv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.toolTipVolReserv.ToolTipTitle = "Erreur saisie";
            toolTipVolReserv.Show("Ne doit contenir que des chiffres", txtVolReserv, txtVolReserv.Location, 5000);

        }

        private int controleSaisieVoiture()
        {
            int controle = 0;
            if (controle == 0 && this.txtImmatriculation.Text.Equals("  -   -"))
            {
                controle = 1;
            }
            if (controle == 0 && this.txtKilometrage.Text.Equals(""))
            {
                controle = 2;
            }
            if (controle == 0 && ((this.dtPickDateAchat.Value.CompareTo(DateTime.MinValue) < 0) ||
                (this.dtPickDateMiseEnCircu.Value.CompareTo(DateTime.MinValue) < 0) ||
                (this.dtPickDateAchat.Value.Date.CompareTo(this.dtPickDateMiseEnCircu.Value.Date) < 0)||
                this.dtPickDateMiseEnCircu.Value.CompareTo(DateTime.Now)>0||
                this.dtPickDateAchat.Value.CompareTo(DateTime.Now)>0))
            {
                controle = 3;
            }
            if (controle==0 && ((this.lstCarburant.SelectedItem.ToString().Equals("--")) ||
               (this.lstCarburant.SelectedItem.ToString().Equals("Ajouter un carburant"))))
            {
                controle = 4;
            }
            if (controle == 0 && this.txtVolReserv.Text.Equals(""))
            {
                controle = 5;
            }   
            if (controle == 0 &&
                ((this.lstMarque.SelectedItem.ToString().Equals("--"))||
                (this.lstModele.SelectedItem.ToString().Equals("Ajouter un modèle")) ||
                (this.lstModele.SelectedItem.ToString().Equals("--"))))
            {
                controle = 6;
            }
            
            return controle;
        }
    }
}
