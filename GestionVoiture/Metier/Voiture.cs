using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Voiture
    {
        private string immatriculation;
        private double kilometrage;
        private DateTime dateMiseEnCirculation;
        private DateTime dateAchat;
        private DateTime dateVente;
        private int volumeReservoir;
        private Modele modele;
        private Carburant carburant;
        private Conducteur conducteur;

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

        public Modele _Modele
        {
            get
            {
                return this.modele;
            }
            set
            {
                this.modele = value;
            }
        }

        public DateTime _DateAchat
        {
            get
            {
                return this.dateAchat;
            }
            set
            {
                this.dateAchat = value;
            }
        }

        public DateTime _DateMiseEnCirculation
        {
            get
            {
                return this.dateMiseEnCirculation;
            }
            set
            {
                this.dateMiseEnCirculation = value;
            }
        }

        public DateTime _DateVente
        {
            get
            {
                return this.dateVente;
            }
            set
            {
                this.dateVente = value;
            }
        }

        public string _Immatriculation
        {
            get
            {
                return this.immatriculation;
            }
            set
            {
                this.immatriculation = value;
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

        public int _VolumeReservoire
        {
            get
            {
                return this.volumeReservoir;
            }
            set
            {
                this.volumeReservoir = value;
            }
        }


    }
}
