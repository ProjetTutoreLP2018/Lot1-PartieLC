using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lot1.UserControlsParametres
{
	//TODO : Implémenter les chargement et la sauvegarde de tous les paramètres

    public partial class UCFenParametresPreRemplissage : UserControl
    {
        public UCFenParametresPreRemplissage()
        {
            InitializeComponent();
        }

		public void ChargerParametres()
		{
			DelimiteurDebutVariable.Text = Properties.Settings.Default.DelimiteurDebutVariable;
			DelimiteurFinVariable.Text = Properties.Settings.Default.DelimiteurFinVariable;
		}

		public void ChargerParametresParDefaut()
		{
			Properties.Settings.Default.DelimiteurDebutVariable = "{{";
			Properties.Settings.Default.DelimiteurFinVariable = "}}";
			Properties.Settings.Default.Save();
			DelimiteurDebutVariable.Text = Properties.Settings.Default.DelimiteurDebutVariable;
			DelimiteurFinVariable.Text = Properties.Settings.Default.DelimiteurFinVariable;
		
		}

		public void SauvegarderParametres()
		{
			Properties.Settings.Default.DelimiteurDebutVariable = DelimiteurDebutVariable.Text;
			Properties.Settings.Default.DelimiteurFinVariable = DelimiteurFinVariable.Text;
			Properties.Settings.Default.Save();
		}

		private void UCFenParametresPreRemplissage_Load(object sender, EventArgs e)
		{
			ChargerParametres();
		}

		private void DelimiteurDebutVariable_Validating(object sender, CancelEventArgs e)
		{
			if(String.IsNullOrWhiteSpace(DelimiteurDebutVariable.Text))
			{
				MessageBox.Show("Le délimiteur de début de variable ne peut être vide", "Le champ ne peut être vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DelimiteurDebutVariable.Focus();
			} else
			{
				if (!Regex.IsMatch(DelimiteurDebutVariable.Text, @"^[\[\]<>{{}}#]+$")) {
					MessageBox.Show("Le délimiteur contient des caractères non autorisés.\nSeuls sont autorisés les symboles suivants :\n<, >, [, ], {, }, #.", "Caractères interdits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					DelimiteurDebutVariable.SelectAll();
					DelimiteurDebutVariable.Focus();
				}
			}
		}

		private void DelimiteurFinVariable_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrWhiteSpace(DelimiteurFinVariable.Text))
			{
				MessageBox.Show("Le délimiteur de fin de variable ne peut être vide", "Le champ ne peut être vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DelimiteurFinVariable.Focus();
			}
			else
			{
				if (!Regex.IsMatch(DelimiteurFinVariable.Text, @"^[\[\]<>{{}}#]+$"))
				{
					MessageBox.Show("Le délimiteur contient des caractères non autorisés.\nSeuls sont autorisés les symboles suivants :\n<, >, [, ], {, }, #.", "Caractères interdits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					DelimiteurFinVariable.SelectAll();
					DelimiteurFinVariable.Focus();
				}
			}
		}
	}
}
