using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lot1
{
    public partial class UCFenParametresEmplacements : UserControl
    {
        public UCFenParametresEmplacements()
        {
            InitializeComponent();
        }

        private void UCFenParametresEmplacements_Load(object sender, EventArgs e)
        {
            ChargerParametres();
        }

        public void ChargerParametres()
        {
            EmplacementFichiersClient.Text = Properties.Settings.Default.EmplacementFichiersClient;
            EmplacementModeles.Text = Properties.Settings.Default.EmplacementModeles;
            EmplacementsFichiersGeneres.Text = Properties.Settings.Default.EmplacementFichiersGeneres;
            EnregistrerFichiersGoogleDrive.Checked = Properties.Settings.Default.EnregistrerFichiersGoogleDrive;
            EnregistrerFichiersLocal.Checked = Properties.Settings.Default.EnregistrerFichiersLocal;
        }

        public void ChargerParametresParDefaut()
        {
            EmplacementFichiersClient.Text = String.Empty;
            EmplacementModeles.Text = String.Empty;
            EmplacementsFichiersGeneres.Text = String.Empty;
            EnregistrerFichiersGoogleDrive.Checked = false;
            EnregistrerFichiersLocal.Checked = false;
            Properties.Settings.Default.EmplacementFichiersClient = String.Empty;
            Properties.Settings.Default.EmplacementModeles = String.Empty;
            Properties.Settings.Default.EmplacementFichiersGeneres = String.Empty;
            Properties.Settings.Default.EnregistrerFichiersGoogleDrive = false;
            Properties.Settings.Default.EnregistrerFichiersLocal = false;
            Properties.Settings.Default.Save();
        }
        
        public void SauvegarderParametres()
        {
            Properties.Settings.Default.EmplacementFichiersClient = EmplacementFichiersClient.Text;
            Properties.Settings.Default.EmplacementModeles = EmplacementModeles.Text;
            Properties.Settings.Default.EmplacementFichiersGeneres = EmplacementsFichiersGeneres.Text;
            Properties.Settings.Default.EnregistrerFichiersGoogleDrive = EnregistrerFichiersGoogleDrive.Checked;
            Properties.Settings.Default.EnregistrerFichiersLocal = EnregistrerFichiersLocal.Checked;
            Properties.Settings.Default.Save();
        }

        private void EmplacementFichiersClient_Validating(object sender, CancelEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(EmplacementFichiersClient.Text))
            {
                if(!Directory.Exists(EmplacementFichiersClient.Text))
                {
                    MessageBox.Show("Le répertoire " + EmplacementFichiersClient.Text + " n'existe pas", "Le répertoire n'existe pas");
                    EmplacementFichiersClient.SelectAll();
                    EmplacementFichiersClient.Focus();
                }
            }
        }

        private void EmplacementModeles_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EmplacementModeles.Text))
            {
                if (!Directory.Exists(EmplacementModeles.Text))
                {
                    MessageBox.Show("Le répertoire " + EmplacementModeles.Text + " n'existe pas", "Le répertoire n'existe pas");
                    EmplacementModeles.SelectAll();
                    EmplacementModeles.Focus();
                }
            }
        }
   
        private void EmplacementsFichiersGeneres_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EmplacementsFichiersGeneres.Text))
            {
                if (!Directory.Exists(EmplacementsFichiersGeneres.Text))
                {
                    MessageBox.Show("Le répertoire " + EmplacementsFichiersGeneres.Text + " n'existe pas", "Le répertoire n'existe pas");
                    EmplacementsFichiersGeneres.SelectAll();
                    EmplacementsFichiersGeneres.Focus();
                }
            }
        }
        private void BoutonDossierParcourirFichiersClient_Click(object sender, EventArgs e)
        {
            if(choixDossier.ShowDialog(this) == DialogResult.OK)
            {
                EmplacementFichiersClient.Text = choixDossier.SelectedPath;
            }
        }

        private void BoutonDossierParcourirModele_Click(object sender, EventArgs e)
        {
            if (choixDossier.ShowDialog(this) == DialogResult.OK)
            {
                EmplacementModeles.Text = choixDossier.SelectedPath;
            }
        }

        private void BoutonParcourirDossierFichierGeneres_Click(object sender, EventArgs e)
        {
            if (choixDossier.ShowDialog(this) == DialogResult.OK)
            {
                EmplacementsFichiersGeneres.Text = choixDossier.SelectedPath;
            }
        }
    }
}
