using lot1.UserControlsParametres;
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
        private List<UserControl> panneaux = new List<UserControl>();
        private UCFenParametresGeneraux fenParametresGeneraux = new UCFenParametresGeneraux();
        private UCFenParametresEmplacements fenParametresEmplacements = new UCFenParametresEmplacements();
        private UCFenParametresBaseDeDonnees fenParametresBaseDeDonnees = new UCFenParametresBaseDeDonnees();
		private UCFenParametresPreRemplissage fenParametresPreRemplissage = new UCFenParametresPreRemplissage();

		public FenParametres()
        {
            InitializeComponent();
        }

        private void FenParametres_Load(object sender, EventArgs e)
        {
            panneaux.Add(fenParametresGeneraux);
            panneaux.Add(fenParametresEmplacements);
            panneaux.Add(fenParametresBaseDeDonnees);
			panneaux.Add(fenParametresPreRemplissage);
            Panneau.Controls.Add(fenParametresGeneraux);
        }

        private void ListeParametres_Click(object sender, EventArgs e)
        {
            UserControl controleUtilisateur = panneaux[ListeParametres.SelectedIndex];
            controleUtilisateur.Dock = DockStyle.Fill;
            Panneau.Controls.Clear();
            Panneau.Controls.Add(controleUtilisateur);
        }

        private void BoutonValider_Click(object sender, EventArgs e)
        {
            fenParametresGeneraux.SauvegarderParametres();
            fenParametresEmplacements.SauvegarderParametres();
			fenParametresPreRemplissage.SauvegarderParametres();
			fenParametresBaseDeDonnees.SauvegarderParametres();
            Close();
        }

        private void ReinitialiserParametres_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment réinitialiser les paramètres ?\nCette opération est irréversible.", "Réinitialiser les paramètres", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                fenParametresGeneraux.ChargerParametresParDefaut();
                fenParametresEmplacements.ChargerParametresParDefaut();
				fenParametresPreRemplissage.ChargerParametresParDefaut();
				fenParametresBaseDeDonnees.ChargerParametresParDefaut();
                MessageBox.Show("Les paramètres ont été réinitialisés avec succès", "Réinitialisation des paramètres");
            }
        }
    }
}
