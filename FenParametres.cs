using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lot1
{
    public partial class FenParametres : Form
    {
        List<UserControl> panneaux = new List<UserControl>();
        public FenParametres()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            UserControl ControleUtilisateur = panneaux[listBox1.SelectedIndex];
            ControleUtilisateur.Dock = DockStyle.Fill;
            panneau.Controls.Clear();
            panneau.Controls.Add(ControleUtilisateur);
        }

        private void FenParametres_Load(object sender, EventArgs e)
        {
            panneaux.Add(new FenParametresGeneraux());
            panneaux.Add(new FenParametresBaseDeDonnees());
        }
    }
}
