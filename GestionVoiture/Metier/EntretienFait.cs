using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class EntretienFait
    {
        private DateTime date;
        private int kilometrage;
        private string commentaire;
        private Voiture voiture;
        private Garage garage;
        private Entretien entretien;

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
    }
}
