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

		public void ChargerParametres()
		{

			BDDNomUtilisateur.Text = Properties.Settings.Default.BDDNomUtilisateur;
			BDDNomHote.Text = Properties.Settings.Default.BDDNomHote;
			BDDNom.Text = Properties.Settings.Default.BDDNom;
			BDDMotDePasse.Text = Properties.Settings.Default.BDDMotDePasse;
		}

        public void ChargerParametresParDefaut()
        {
			Properties.Settings.Default.BDDNomUtilisateur = String.Empty;
			Properties.Settings.Default.BDDNomHote = String.Empty;
			Properties.Settings.Default.BDDNom = String.Empty;
			Properties.Settings.Default.BDDMotDePasse = String.Empty;

			Properties.Settings.Default.Save();


			BDDNomUtilisateur.Text = Properties.Settings.Default.BDDNomUtilisateur;
			BDDNomHote.Text = Properties.Settings.Default.BDDNomHote;
			BDDNom.Text = Properties.Settings.Default.BDDNom;
			BDDMotDePasse.Text = Properties.Settings.Default.BDDMotDePasse;

		}

		public void SauvegarderParametres()
		{
			Properties.Settings.Default.BDDNomUtilisateur = BDDNomUtilisateur.Text;
			Properties.Settings.Default.BDDNomHote = BDDNomHote.Text;
			Properties.Settings.Default.BDDNom = BDDNom.Text;
			Properties.Settings.Default.BDDMotDePasse = BDDMotDePasse.Text;

			Properties.Settings.Default.Save();
		}

		private void UCFenParametresBaseDeDonnees_Load(object sender, EventArgs e)
		{
			ChargerParametres();
		}
	}
}
