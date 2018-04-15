﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lot1
{
    public partial class FenGenerationLC : Form
    {
        /// <summary>
        /// Contient le chemin vers le modèle sélectionné par l'utilisateur
        /// </summary>
        public String ModeleSelectionne;

        /// <summary>
        /// Contient le chemin vers le fichier de destination sélectionné par l'utilisateur
        /// </summary>
        public String DestinationSelectionnee;

        /// <summary>
        /// Initialise les composants graphiques
        /// </summary>
        public FenGenerationLC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche une boîte de dialogue pour sélectionner un modèle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParcourirModele_Click(object sender, EventArgs e)
        {
            //OuvrirModele.InitialDirectory = Properties.Settings.Default.dossierLC;
            if(OuvrirModele.ShowDialog() == DialogResult.OK)
            {
                SelectionModele.Text = OuvrirModele.FileName;
            }
        }

        /// <summary>
        /// Affiche une boîte de dialogue pour sélectionner un fichier cible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParcourirDestination_Click(object sender, EventArgs e)
        {
            if(OuvrirDestination.ShowDialog() == DialogResult.OK)
            {
                SelectionDestination.Text = OuvrirDestination.FileName;
            }
        }

        /// <summary>
        /// Place les chemins des deux fichiers modèle et destination dans les variables ModeleSelectionne et DestinationSelectionnee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonGenerer_Click(object sender, EventArgs e)
        {
                ModeleSelectionne = SelectionModele.Text;
                DestinationSelectionnee = SelectionDestination.Text;
        }

        /// <summary>
        /// Désactive ou active le bouton Générer en fonction du contenu des champs
        /// </summary>
        private void ActiverBoutonGenerer()
        {
            BoutonGenerer.Enabled = (SelectionModele.Text != "" 
                && SelectionDestination.Text != "" 
                && File.Exists(@SelectionModele.Text) ?  true : false);
        }

        /// <summary>
        /// Vérifie si le champ Modèle est rempli et que le chemin renseigné pointe vers un fichier qui existe, affiche une erreur le cas échéant et désactive le bouton Générer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionModele_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(@SelectionModele.Text))
            {
                AffichageErreurs.SetIconPadding(SelectionModele, 2);
                AffichageErreurs.SetError(SelectionModele, "Le champ doit être renseigné");
            }
            else
            {
                if(File.Exists(@SelectionModele.Text))
                {
                    AffichageErreurs.SetError(SelectionModele, "");
                } else
                {
                    AffichageErreurs.SetIconPadding(SelectionModele, 2);
                    AffichageErreurs.SetError(SelectionModele, "Le fichier n'existe pas");
                }
            }
            ActiverBoutonGenerer();
        }

        /// <summary>
        /// Vérifie que le champ Destination est bien renseigné, affiche une erreur le cas échéant et désactive le bouton Générer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionDestination_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(@SelectionDestination.Text))
            {
                AffichageErreurs.SetIconPadding(SelectionDestination, 2);
                AffichageErreurs.SetError(SelectionDestination, "Le champ doit être renseigné");
            }
            else
            {
                AffichageErreurs.SetError(SelectionDestination, "");
            }
            ActiverBoutonGenerer();
        }

        /// <summary>
        /// Permet de valider l'existence du fichier modèle à la perte du focus du champ Modèle, affiche une erreur le cas échéant et désactive le bouton Générer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionModele_Validating(object sender, CancelEventArgs e)
        {
            if (File.Exists(@SelectionModele.Text))
            {
                AffichageErreurs.SetError(SelectionModele, "");
            }
            else
            {
                AffichageErreurs.SetIconPadding(SelectionModele, 2);
                AffichageErreurs.SetError(SelectionModele, "Le fichier n'existe pas");
            }
            ActiverBoutonGenerer();
        }

        private void FenGenerationLC_Load(object sender, EventArgs e)
        {
            ActiverBoutonGenerer();

        }

        private void ChargerParametres()
        {
            Properties.Settings parametres = Properties.Settings.Default;
        }
    }
}
