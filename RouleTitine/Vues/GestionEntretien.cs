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
    public partial class GestionEntretien : Form
    {
        private Voiture voiture;
        public GestionEntretien(Voiture voit)
        {
            InitializeComponent();
            this.voiture = voit;
            DALModele.getSetEntretiensReguliers(this.voiture._Modele);
        }

        private void btnSaisirEntretien_Click(object sender, EventArgs e)
        {

            //Initialisation des listes
            //Liste des entretiens
            this.cbLstEntretiens.Items.Clear();
            this.cbLstEntretiens.Items.Add("--");
            this.cbLstEntretiens.Items.Add("Tapez le nom d'un entretien ponctuel");
            if (this.voiture._Modele._LstEntretiens.Count > 0)
            {
                this.cbLstEntretiens.Items.AddRange(this.voiture._Modele._LstEntretiens.ToArray());
            }

            //Liste des garages
            List<Garage> lstGarages = DALGarage.getAllGarages();
            this.cbLstGarages.Items.Clear();
            this.cbLstGarages.Items.Add("--");
            this.cbLstGarages.Items.Add("Ajouter un garage");
            if (lstGarages.Count > 0)
            {
                this.cbLstGarages.Items.AddRange(lstGarages.ToArray());
            }

            this.gbNouvelEntretien.Visible = true;

        }

        private void cbLstGarages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLstGarages.SelectedItem.ToString().Equals("Ajouter un garage"))
            {
                NouveauGarage nvGar = new NouveauGarage();
                DialogResult dr = nvGar.ShowDialog();
                switch (dr)
                {
                    case System.Windows.Forms.DialogResult.OK:
                        this.cbLstGarages.Items.Clear();
                        this.cbLstGarages.Items.Add("--");
                        List<Garage> lstGarages = DALGarage.getAllGarages();
                        this.cbLstGarages.Items.AddRange(lstGarages.ToArray());
                        this.cbLstGarages.SelectedIndex = 0;
                        break;
                    case System.Windows.Forms.DialogResult.Abort:
                        MessageBox.Show("Une erreur est survenue lors de l'enregistrement du garage");
                        break;
                }
            }

        }

        private void btnEnregistrerEntretien_Click(object sender, EventArgs e)
        {
            int controle = ControleSaisieUtilisateur();
            string typeEntretien;
            switch (controle)
            {
                case 0:
                    long idEntretien;
                    EntretienFait ent = new EntretienFait();
                    if (this.txtNomPiece.Text.CompareTo("1") > 0)
                    {
                        EntretienPonctuel unEntretienP = new EntretienPonctuel();
                        unEntretienP._Nom = cbLstEntretiens.Text;
                        unEntretienP._PieceConcerne = this.txtNomPiece.Text;
                        idEntretien = DALEntretienPonctuel.insert(unEntretienP);
                        typeEntretien = "P";
                        ent._Entretien = unEntretienP;
                    }
                    else
                    {
                        EntretienRegulier unEntretienR = (EntretienRegulier)cbLstEntretiens.SelectedItem;
                        ent._Entretien = unEntretienR;
                        idEntretien = unEntretienR._Id;
                        typeEntretien = "R";
                    }
                    
                    ent._Date = this.datePickerDtEntretien.Value;
                    ent._Kilometrage = Convert.ToInt32(this.txtKilometrageEntretien.Text);
                    ent._Commentaire = this.txtCommentaireEntretien.Text;
                    ent._Voiture = this.voiture;
                    ent._Garage = (Garage)this.cbLstGarages.SelectedItem;
                    ent._Prix = Convert.ToDecimal(this.txtMtEntretien.Text);
                    ent._TypeEntretien = typeEntretien;
                    ent._Entretien._Id = idEntretien;
                    long entEnregistre = DALEntretienFait.insert(ent);
                    if (entEnregistre >= 0)
                    {
                        MessageBox.Show("L'opération a été correctement enregistrée");
                        ReinitialiserSaisieEntretien();                        

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement");
                        ReinitialiserSaisieEntretien();
                    }
                    break;
                case 1:
                    lblErreur.Text = "Aucun entretien sélectionné";
                    break;
                case 2:
                    lblErreur.Text = "Aucun garage sélectionné";
                    break;
                case 3:
                    lblErreur.Text = "Aucun montant renseigné";
                    break;
                case 4:
                    lblErreur.Text = "La date ne peut pas être postérieure à aujourd'hui";
                    break;
                case 5:
                    lblErreur.Text = "Quel est le kilométrage de la voiture au moment de l'entretien ?";
                    break;
            }
        }

        private int ControleSaisieUtilisateur()
        {
            int controle = 0;
            if (this.cbLstEntretiens.SelectedItem == null &&
                this.cbLstEntretiens.Text.ToString().Equals(""))
            {
                controle = 1;
            }
            if (controle==0 && 
               (this.cbLstEntretiens.SelectedItem != null &&
               (this.cbLstEntretiens.SelectedItem.ToString().Equals("--")||
                this.cbLstEntretiens.SelectedItem.ToString().Equals("Tapez le nom d'un entretien ponctuel"))))
            {
                controle = 1;
            }
            if(controle == 0
                &&(this.cbLstGarages.SelectedItem.ToString().Equals("--")
                || this.cbLstGarages.SelectedItem.ToString().Equals("Ajouter un garage")))
            {
                controle = 2;
            }
            if(controle == 0 &&
                this.txtMtEntretien.Text.Equals(""))
            {
                controle = 3;
            }
            if(controle==0 &&
                this.datePickerDtEntretien.Value.Date.CompareTo(DateTime.Today.Date) > 0)
            {
                controle = 4;
            }
            if(controle == 0 &&
                this.txtKilometrageEntretien.Text.Equals(""))
            {
                controle = 5;
            }
            return controle;

        }

        private void ReinitialiserSaisieEntretien()
        {
            this.cbLstEntretiens.SelectedIndex = 0;
            this.cbLstGarages.SelectedIndex = 0;
            this.cbLstGarages.Items.Insert(1, "Ajouter un garage");
            this.txtCommentaireEntretien.Text = "";
            this.txtKilometrageEntretien.Text = "";
            this.txtMtEntretien.Text = "";
            this.datePickerDtEntretien.Value = DateTime.Today;
            this.txtNomPiece.Text = "";
            this.gbNouvelEntretien.Visible= false;
        }
    }
}
