﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Assureur
    {
        private string nom;
        private string adresse;
        private string codePostal;
        private string ville;
        private string telephone;

        public string _Adresse
        {
            get
            {
                return this.adresse;
            }
            set
            {
                this.adresse = value;
            }
        }

        public string _CodePostal
        {
            get
            {
                return this.codePostal;
            }
            set
            {
                this.codePostal = value;

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

        public string _Telephone
        {
            get
            {
                return this.telephone;
            }
            set
            {
                this.telephone = value;
            }
        }

        public string _Ville
        {
            get
            {
                return this.ville;
            }
            set
            {
                this.ville = value;
            }
        }
    }


}
