using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class EntretienAFaire
    {
        private EntretienRegulier entretienRegulier;
        private Modele modele;

        public EntretienRegulier _EntretienRegulier
        {
            get
            {
                return this.entretienRegulier;
            }
            set
            {
                this.entretienRegulier = value;
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
    }
}
