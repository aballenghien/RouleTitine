using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionVoiture;

namespace RouleTitine
{
    
    public partial class MenuVoiture : Form
    {
        private Conducteur conductConnecte;
        private List<Voiture> lstVoiture;
        public MenuVoiture(Conducteur c)
        {
            InitializeComponent();
            this.conductConnecte = c;
        }
    }
}
