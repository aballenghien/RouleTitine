using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class EntretienPonctuel : Entretien
    {
        private string pieceConcerne;

        public string _PieceConcerne
        {
            get
            {
                return this.pieceConcerne;
            }
            set
            {
                this.pieceConcerne = value;
            }
        }
    }
}
