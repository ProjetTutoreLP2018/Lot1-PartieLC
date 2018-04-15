namespace lot1
{
    partial class UCFenParametresEmplacements
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmplacementModeles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmplacementsFichiersGeneres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmplacementFichiersClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnregistrerFichiersGoogleDrive = new System.Windows.Forms.CheckBox();
            this.EnregistrerFichiersLocal = new System.Windows.Forms.CheckBox();
            this.BoutonDossierParcourirFichiersClient = new System.Windows.Forms.Button();
            this.BoutonDossierParcourirModele = new System.Windows.Forms.Button();
            this.BoutonParcourirDossierFichierGeneres = new System.Windows.Forms.Button();
            this.choixDossier = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoutonParcourirDossierFichierGeneres);
            this.groupBox1.Controls.Add(this.BoutonDossierParcourirModele);
            this.groupBox1.Controls.Add(this.BoutonDossierParcourirFichiersClient);
            this.groupBox1.Controls.Add(this.EmplacementModeles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmplacementsFichiersGeneres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmplacementFichiersClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emplacements";
            // 
            // EmplacementModeles
            // 
            this.EmplacementModeles.Location = new System.Drawing.Point(9, 91);
            this.EmplacementModeles.Name = "EmplacementModeles";
            this.EmplacementModeles.Size = new System.Drawing.Size(299, 22);
            this.EmplacementModeles.TabIndex = 5;
            this.EmplacementModeles.Validating += new System.ComponentModel.CancelEventHandler(this.EmplacementModeles_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emplacement des modèles : ";
            // 
            // EmplacementsFichiersGeneres
            // 
            this.EmplacementsFichiersGeneres.Location = new System.Drawing.Point(9, 144);
            this.EmplacementsFichiersGeneres.Name = "EmplacementsFichiersGeneres";
            this.EmplacementsFichiersGeneres.Size = new System.Drawing.Size(299, 22);
            this.EmplacementsFichiersGeneres.TabIndex = 3;
            this.EmplacementsFichiersGeneres.Validating += new System.ComponentModel.CancelEventHandler(this.EmplacementsFichiersGeneres_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emplacement des fichiers générés : ";
            // 
            // EmplacementFichiersClient
            // 
            this.EmplacementFichiersClient.Location = new System.Drawing.Point(9, 42);
            this.EmplacementFichiersClient.Name = "EmplacementFichiersClient";
            this.EmplacementFichiersClient.Size = new System.Drawing.Size(299, 22);
            this.EmplacementFichiersClient.TabIndex = 1;
            this.EmplacementFichiersClient.Validating += new System.ComponentModel.CancelEventHandler(this.EmplacementFichiersClient_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emplacement des fichiers client : ";
            // 
            // EnregistrerFichiersGoogleDrive
            // 
            this.EnregistrerFichiersGoogleDrive.AutoSize = true;
            this.EnregistrerFichiersGoogleDrive.Location = new System.Drawing.Point(17, 211);
            this.EnregistrerFichiersGoogleDrive.Name = "EnregistrerFichiersGoogleDrive";
            this.EnregistrerFichiersGoogleDrive.Size = new System.Drawing.Size(272, 17);
            this.EnregistrerFichiersGoogleDrive.TabIndex = 1;
            this.EnregistrerFichiersGoogleDrive.Text = "Enregistrer les fichiers générés sur Google Drive";
            this.EnregistrerFichiersGoogleDrive.UseVisualStyleBackColor = true;
            // 
            // EnregistrerFichiersLocal
            // 
            this.EnregistrerFichiersLocal.AutoSize = true;
            this.EnregistrerFichiersLocal.Location = new System.Drawing.Point(17, 234);
            this.EnregistrerFichiersLocal.Name = "EnregistrerFichiersLocal";
            this.EnregistrerFichiersLocal.Size = new System.Drawing.Size(226, 17);
            this.EnregistrerFichiersLocal.TabIndex = 2;
            this.EnregistrerFichiersLocal.Text = "Enregistrer les fichiers générés en local";
            this.EnregistrerFichiersLocal.UseVisualStyleBackColor = true;
            // 
            // BoutonDossierParcourirFichiersClient
            // 
            this.BoutonDossierParcourirFichiersClient.Location = new System.Drawing.Point(315, 42);
            this.BoutonDossierParcourirFichiersClient.Name = "BoutonDossierParcourirFichiersClient";
            this.BoutonDossierParcourirFichiersClient.Size = new System.Drawing.Size(45, 23);
            this.BoutonDossierParcourirFichiersClient.TabIndex = 6;
            this.BoutonDossierParcourirFichiersClient.Text = "...";
            this.BoutonDossierParcourirFichiersClient.UseVisualStyleBackColor = true;
            this.BoutonDossierParcourirFichiersClient.Click += new System.EventHandler(this.BoutonDossierParcourirFichiersClient_Click);
            // 
            // BoutonDossierParcourirModele
            // 
            this.BoutonDossierParcourirModele.Location = new System.Drawing.Point(315, 91);
            this.BoutonDossierParcourirModele.Name = "BoutonDossierParcourirModele";
            this.BoutonDossierParcourirModele.Size = new System.Drawing.Size(45, 23);
            this.BoutonDossierParcourirModele.TabIndex = 7;
            this.BoutonDossierParcourirModele.Text = "...";
            this.BoutonDossierParcourirModele.UseVisualStyleBackColor = true;
            this.BoutonDossierParcourirModele.Click += new System.EventHandler(this.BoutonDossierParcourirModele_Click);
            // 
            // BoutonParcourirDossierFichierGeneres
            // 
            this.BoutonParcourirDossierFichierGeneres.Location = new System.Drawing.Point(315, 144);
            this.BoutonParcourirDossierFichierGeneres.Name = "BoutonParcourirDossierFichierGeneres";
            this.BoutonParcourirDossierFichierGeneres.Size = new System.Drawing.Size(45, 23);
            this.BoutonParcourirDossierFichierGeneres.TabIndex = 8;
            this.BoutonParcourirDossierFichierGeneres.Text = "...";
            this.BoutonParcourirDossierFichierGeneres.UseVisualStyleBackColor = true;
            this.BoutonParcourirDossierFichierGeneres.Click += new System.EventHandler(this.BoutonParcourirDossierFichierGeneres_Click);
            // 
            // UCFenParametresEmplacements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnregistrerFichiersLocal);
            this.Controls.Add(this.EnregistrerFichiersGoogleDrive);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCFenParametresEmplacements";
            this.Size = new System.Drawing.Size(397, 316);
            this.Load += new System.EventHandler(this.UCFenParametresEmplacements_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmplacementsFichiersGeneres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmplacementFichiersClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox EnregistrerFichiersGoogleDrive;
        private System.Windows.Forms.CheckBox EnregistrerFichiersLocal;
        private System.Windows.Forms.TextBox EmplacementModeles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BoutonParcourirDossierFichierGeneres;
        private System.Windows.Forms.Button BoutonDossierParcourirModele;
        private System.Windows.Forms.Button BoutonDossierParcourirFichiersClient;
        private System.Windows.Forms.FolderBrowserDialog choixDossier;
    }
}
