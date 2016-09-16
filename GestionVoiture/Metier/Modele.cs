using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Modele
    {
        private string nom;
        private Marque marque;

        public Marque _Marque
        {
            get
            {
                return this.marque;
            }
            set
            {
                this.marque = value;
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
    }
}
