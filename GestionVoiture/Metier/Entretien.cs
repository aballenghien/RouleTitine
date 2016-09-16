using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public abstract class Entretien
    {
        private string nom;
        private decimal prix;

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
