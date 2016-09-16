using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class PleinCarburant
    {
        private DateTime date;
        private decimal prixLitre;
        private decimal nbLitre;
        private double kilometrage;
        private Carburant carburant;
        private StationEssence stationEssence;
        private Voiture voiture;

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

        public Carburant _Carburant
        {
            get
            {
                return this.carburant;
            }
            set
            {
                this.carburant = value;
            }
        }

        public StationEssence _StationEssence
        {
            get
            {
                return this.stationEssence;
            }
            set
            {
                this.stationEssence = value;
            }
        }

        public DateTime _Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public double _Kilometrage
        {
            get
            {
                return this.kilometrage;
            }
            set
            {
                this.kilometrage = value;
            }
        }

        public decimal _NbLitre
        {
            get
            {
                return this.nbLitre;
            }
            set
            {
                this.nbLitre = value;
            }
        }

        public decimal _PrixLitre
        {
            get
            {
                return this.prixLitre;
            }
            set
            {
                this.prixLitre = value;
            }
        }

        public decimal _PrixTotal
        {
            get
            {
                return this.nbLitre * this.prixLitre;
            }
        }
    }
}
