using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVoiture
{
    public class EntretienRegulier : Entretien
    {
        /// <summary>
        /// Période avant de refaire l'entretien
        /// en mois
        /// </summary>
        private int periode;
        /// <summary>
        /// Nombre de kilomètre entre chaque entretien
        /// </summary>
        private double kilometrage;

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

        public int _Periode
        {
            get
            {
                return this.periode;
            }
            set
            {
                this.periode = value;
            }
        }
    }
}
