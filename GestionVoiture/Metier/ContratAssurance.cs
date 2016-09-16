using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class ContratAssurance
    {
        private string nom;
        private decimal prix;
        private string categorie;
        private Assureur assureur;
        private Conducteur conducteur;
        private Voiture voiture;

        public Conducteur _Conducteur
        {
            get
            {
                return this.conducteur;
            }
            set
            {
                this.conducteur = value;
            }
        }

        public Voiture _Voiture
        {
            get
            {
                return this.voiture;
            }
            set
            {
                this.voiture = value;
            }
        }

        public Assureur _Assureur
        {
            get
            {
                return this.assureur;
            }
            set
            {
                this.assureur = value;
            }
        }

        public string _Categorie
        {
            get
            {
                return this.categorie;
            }
            set
            {
                this.categorie = value;
            }
        }

        public string _Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public decimal _Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                this.prix = value;
            }
        }
    }
}
