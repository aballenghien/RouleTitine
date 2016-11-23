using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class EntretienFait
    {
        private long id;
        private DateTime date;
        private int kilometrage;
        private string commentaire;
        private Voiture voiture;
        private Garage garage;
        private Entretien entretien;
        private decimal prix;
        private string typeEntretien;

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

        public Garage _Garage
        {
            get
            {
                return this.garage;
            }
            set
            {
                this.garage = value;
            }
        }

        public Entretien _Entretien
        {
            get
            {
                return this.entretien;
            }
            set
            {
                this.entretien = value;
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

        public int _Kilometrage
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

        public string _Commentaire
        {
            get
            {
                return this.commentaire;
            }
            set
            {
                this.commentaire = value;
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

        public long _Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id= value;
            }
        }

        public string _TypeEntretien
        {
            get
            {
                return this.typeEntretien;
            }
            set
            {
                this.typeEntretien = value;
            }
        }
    }
}
