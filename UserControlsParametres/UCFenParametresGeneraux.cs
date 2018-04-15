using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Specialized;

namespace lot1
{
    public partial class UCFenParametresGeneraux : UserControl
    {
        public UCFenParametresGeneraux()
        {
            InitializeComponent();
        }

        private void UCFenParametresGeneraux_Load(object sender, EventArgs e)
        {
            ChargerParametres();
        }

        public void ChargerParametres()
        {
            FormatDate.SelectedIndex = Properties.Settings.Default.FormatDate;
            DateADateDuJour.Checked = Properties.Settings.Default.DateCouranteADateDuJour;
            MillesimeAAnneeCourante.Checked = Properties.Settings.Default.MillesimeADateCourante;
            ListeFormesJuridiques.Items.Clear();
            ListeFormesJuridiques.Items.AddRange(Properties.Settings.Default.FormesJuridiques.Cast<String>().ToArray());
        }

        public void ChargerParametresParDefaut()
        {
            Properties.Settings.Default.FormatDate = 1;
            Properties.Settings.Default.DateCouranteADateDuJour = false;
            Properties.Settings.Default.MillesimeADateCourante = false;
            Properties.Settings.Default.FormesJuridiques = new StringCollection()
            {
                "EI",
                "EIRL",
                "EURL",
                "SA",
                "SARL",
                "SAS",
                "SASU",
                "SC",
                "SCA",
                "SCIC",
                "SCOP",
                "SNC",
            };
            Properties.Settings.Default.Save();
            FormatDate.SelectedIndex = Properties.Settings.Default.FormatDate;
            DateADateDuJour.Checked = Properties.Settings.Default.DateCouranteADateDuJour;
            MillesimeAAnneeCourante.Checked = Properties.Settings.Default.MillesimeADateCourante;
            ListeFormesJuridiques.Items.Clear();
            ListeFormesJuridiques.Items.AddRange(Properties.Settings.Default.FormesJuridiques.Cast<String>().ToArray());

        }

        public void SauvegarderParametres()
        {
            Properties.Settings.Default.FormatDate = FormatDate.SelectedIndex;
            Properties.Settings.Default.DateCouranteADateDuJour = DateADateDuJour.Checked;
            Properties.Settings.Default.MillesimeADateCourante = MillesimeAAnneeCourante.Checked;
            StringCollection formesJuridiques = new StringCollection();
            foreach(var item in ListeFormesJuridiques.Items)
            {
                formesJuridiques.Add(item.ToString()); 
            }
            Properties.Settings.Default.FormesJuridiques = formesJuridiques;
            Properties.Settings.Default.Save();
        }

        private void MonterItem_Click(object sender, EventArgs e)
        {
            if (ListeFormesJuridiques.SelectedItem == null || ListeFormesJuridiques.SelectedIndex < 0)
            {
                return;
            }

            int nouvelIndice = ListeFormesJuridiques.SelectedIndex - 1;
            if (nouvelIndice < 0 || nouvelIndice >= ListeFormesJuridiques.Items.Count)
            {
                return;
            }

            object itemSelectionne = ListeFormesJuridiques.SelectedItem;
            ListeFormesJuridiques.Items.Remove(itemSelectionne);
            ListeFormesJuridiques.Items.Insert(nouvelIndice, itemSelectionne);
            ListeFormesJuridiques.SetSelected(nouvelIndice, true);
        }

        private void DescendreItem_Click(object sender, EventArgs e)
        {
            if (ListeFormesJuridiques.SelectedItem == null || ListeFormesJuridiques.SelectedIndex < 0)
            {
                return;
            }

            int nouvelIndice = ListeFormesJuridiques.SelectedIndex + 1;
            if (nouvelIndice < 0 || nouvelIndice >= ListeFormesJuridiques.Items.Count)
            {
                return; 
            }

            object itemSelectionne = ListeFormesJuridiques.SelectedItem;
            ListeFormesJuridiques.Items.Remove(itemSelectionne);
            ListeFormesJuridiques.Items.Insert(nouvelIndice, itemSelectionne);
            ListeFormesJuridiques.SetSelected(nouvelIndice, true);
        }

        private void SupprimerItem_Click(object sender, EventArgs e)
        {
			if (ListeFormesJuridiques.SelectedItem != null || ListeFormesJuridiques.SelectedIndex > 0)
			{
				if (MessageBox.Show(String.Format("Voulez-vous vraiment supprimer '{0}' ?", ListeFormesJuridiques.SelectedItem.ToString()), "Suppression d'une forme juridique", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					ListeFormesJuridiques.Items.RemoveAt(ListeFormesJuridiques.SelectedIndex);
					ListeFormesJuridiques.SelectedIndex = ListeFormesJuridiques.Items.Count - 1;
				}
			}
        }

        private void AjouterItem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(ItemARajouter.Text))
            {
                ListeFormesJuridiques.Items.Add(ItemARajouter.Text);
            } else
            {
                MessageBox.Show("Vous ne pouvez pas ajouter un item vide", "Ajout impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
