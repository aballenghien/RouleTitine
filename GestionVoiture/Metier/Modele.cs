using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class Modele
    {
        private long id;
        private string nom;
        private Marque marque;
        private List<EntretienRegulier> lstEntretiens;

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

        public List<EntretienRegulier> _LstEntretiens
        {
            get
            {
                return this.lstEntretiens;
            }
            set
            {
                this.lstEntretiens = value;
            }
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
