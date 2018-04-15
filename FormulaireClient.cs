using System;
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
    public partial class SIRET : Form
    {
        public SIRET()
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

        private void BoutonValider_Click(object sender, EventArgs e)
        {
                Client client = new Client();
                client.OrganisationComptable = NomOrganisation.Text;
                Model modele = new Model();
                modele.CreerClient(client);
                MessageBox.Show("Le client " + client.OrganisationComptable + " a bien été créé", "Création d'un client");
        }

       
    }
}
