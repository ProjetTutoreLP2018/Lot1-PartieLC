using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lot1
{
	//TODO : Implémenter le chargement des paramètres, le chargement des paramètres par défaut et la sauvegarde
    public partial class UCFenParametresBaseDeDonnees : UserControl
    {
        public UCFenParametresBaseDeDonnees()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox2.Checked = EnregistrerInfosConnexionBDD.Checked ? true : false;
        }

        public void ChargerParametresParDefaut()
        {

        }
    }
}
