using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public abstract class Entretien
    {
        private long id;
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

        public long _Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            return this.nom;
        }

    }
}
