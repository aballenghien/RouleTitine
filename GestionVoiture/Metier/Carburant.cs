﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Carburant
    {
        private string nom;

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

        public override string ToString()
        {
            return this.nom;
        }
    }
}
