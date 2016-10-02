using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Marque
    {

        private string nom;

        public Marque(string nom)
        {
            this.nom = nom;
        }

        public Marque()
        {

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

        public override string ToString()
        {
            return this.nom;
        }
    }
}
