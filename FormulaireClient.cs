﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modele;

namespace lot1
{
    public partial class FormulaireClient : Form
    {
        public FormulaireClient()
        {
            InitializeComponent();
        }

        private void FormulaireClient_Load(object sender, EventArgs e)
        {
        }

        private void préremplirAutomatiquementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PreremplirAutomatiquement();
        }

        private void PreremplirAutomatiquement()
        {
            FenPreRemplissageAutomatique fenPreRemplissageAutomatique = new FenPreRemplissageAutomatique();
            if (fenPreRemplissageAutomatique.ShowDialog(this) == DialogResult.OK)
            {
                Record enregistrement = fenPreRemplissageAutomatique.entrepriseSelectionnee;
                NomOrganisation.Text = enregistrement.fields.l1_normalisee;
                FormeJuridique.Text = enregistrement.fields.libnj.Split(',')[0];
                Adresse.Text = String.Format("{0} {1} {2}", enregistrement.fields.numvoie, enregistrement.fields.typvoie, enregistrement.fields.libvoie);
                CodePostal.Text = enregistrement.fields.codpos;
                Ville.Text = enregistrement.fields.libcom;
                //Activite.Text = enregistrement.fields.libapet;
            }
        }

        private async void BoutonValider_Click(object sender, EventArgs e)
        {
			await Task.Run(() => {
				try
				{
					Model modele = new Model();

					Adresse adresse = new Adresse();
					adresse.Numero = NumeroVoie.Text;
					adresse.Indice = IndiceRepetition.SelectedItem.ToString();
					adresse.Voie = Adresse.Text;
					adresse.Complements = Complement.Text;
					adresse.CodePostal = CodePostal.Text;
					adresse.Ville = Ville.Text;

					modele.CreerAdresse(adresse);

					Client client = new Client();
					client.Ca = (double) CA.Value;
					client.DateImmatriculation = DateImmatriculation.Value;
					client.Effectifs = (int) Effectif.Value;
					client.Ess = ESSOui.Checked;
					client.FonctionReferent = FonctionRepresentant.Text;
					client.FormeJuridique = FormeJuridique.Text;
					client.LieuImmatriculation = LieuImmatriculation.Text;
					client.NomReferent = NomRepresentant.Text;
					client.OrganisationComptable = OrganisationComptable.Text;
					client.PrenomReferent = PrenomRepresentant.Text;
					client.RaisonSociale = NomOrganisation.Text;
					client.SexeReferent = SexeRepresentant.Text;
					client.Siret = NumeroSiret.Text;
					client.SiteWeb = SiteInternet.Text;
					client.TelFix = TelephoneRepresentant.Text;
					client.TelPortable = TelephonePortableRepresentant.Text;
					client.VolumeAnnuel = Double.Parse(VolumesAnnuels.Text);
					client.IdAdresse = adresse.IdAdresse;

					modele.CreerClient(client);

				} catch(Exception ex)
				{
					MessageBox.Show("Une erreur est survenue. Veuillez réessayer.\nSi cette erreur se reproduit à l'avenir, contactez le développeur du logiciel en lui indiquant le message d'erreur.\nMessage d'erreur : " + ex.InnerException.Message, "Erreur", MessageBoxButtons.OK);
				}
			});

			
		}
	}
}
