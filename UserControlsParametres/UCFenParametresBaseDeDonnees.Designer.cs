namespace lot1
{
    partial class UCFenParametresBaseDeDonnees
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
            this.BDDPort = new System.Windows.Forms.NumericUpDown();
            this.BDDNom = new System.Windows.Forms.TextBox();
            this.BDDNomHote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BDDMotDePasse = new System.Windows.Forms.TextBox();
            this.BDDNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoutonTestConnexion = new System.Windows.Forms.Button();
            this.EnregistrerInfosConnexionBDD = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDDPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BDDPort);
            this.groupBox1.Controls.Add(this.BDDNom);
            this.groupBox1.Controls.Add(this.BDDNomHote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BDDMotDePasse);
            this.groupBox1.Controls.Add(this.BDDNomUtilisateur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de connexion";
            // 
            // BDDPort
            // 
            this.BDDPort.Location = new System.Drawing.Point(128, 97);
            this.BDDPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BDDPort.Name = "BDDPort";
            this.BDDPort.Size = new System.Drawing.Size(120, 22);
            this.BDDPort.TabIndex = 10;
            // 
            // BDDNom
            // 
            this.BDDNom.Location = new System.Drawing.Point(186, 128);
            this.BDDNom.Name = "BDDNom";
            this.BDDNom.Size = new System.Drawing.Size(198, 22);
            this.BDDNom.TabIndex = 9;
            // 
            // BDDNomHote
            // 
            this.BDDNomHote.Location = new System.Drawing.Point(128, 72);
            this.BDDNomHote.Name = "BDDNomHote";
            this.BDDNomHote.Size = new System.Drawing.Size(246, 22);
            this.BDDNomHote.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom de la base de données  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port : ";
            // 
            // BDDMotDePasse
            // 
            this.BDDMotDePasse.Location = new System.Drawing.Point(128, 46);
            this.BDDMotDePasse.Name = "BDDMotDePasse";
            this.BDDMotDePasse.Size = new System.Drawing.Size(246, 22);
            this.BDDMotDePasse.TabIndex = 6;
            this.BDDMotDePasse.UseSystemPasswordChar = true;
            // 
            // BDDNomUtilisateur
            // 
            this.BDDNomUtilisateur.Location = new System.Drawing.Point(128, 20);
            this.BDDNomUtilisateur.Name = "BDDNomUtilisateur";
            this.BDDNomUtilisateur.Size = new System.Drawing.Size(246, 22);
            this.BDDNomUtilisateur.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom d\'hôte : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur : ";
            // 
            // BoutonTestConnexion
            // 
            this.BoutonTestConnexion.Location = new System.Drawing.Point(253, 182);
            this.BoutonTestConnexion.Name = "BoutonTestConnexion";
            this.BoutonTestConnexion.Size = new System.Drawing.Size(141, 23);
            this.BoutonTestConnexion.TabIndex = 1;
            this.BoutonTestConnexion.Text = "Tester la connexion";
            this.BoutonTestConnexion.UseVisualStyleBackColor = true;
            // 
            // EnregistrerInfosConnexionBDD
            // 
            this.EnregistrerInfosConnexionBDD.AutoSize = true;
            this.EnregistrerInfosConnexionBDD.Location = new System.Drawing.Point(25, 236);
            this.EnregistrerInfosConnexionBDD.Name = "EnregistrerInfosConnexionBDD";
            this.EnregistrerInfosConnexionBDD.Size = new System.Drawing.Size(237, 17);
            this.EnregistrerInfosConnexionBDD.TabIndex = 2;
            this.EnregistrerInfosConnexionBDD.Text = "Enregister les informations de connexion";
            this.EnregistrerInfosConnexionBDD.UseVisualStyleBackColor = true;
            this.EnregistrerInfosConnexionBDD.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UCFenParametresBaseDeDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnregistrerInfosConnexionBDD);
            this.Controls.Add(this.BoutonTestConnexion);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCFenParametresBaseDeDonnees";
            this.Size = new System.Drawing.Size(397, 316);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDDPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BDDNom;
        private System.Windows.Forms.TextBox BDDNomHote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BDDMotDePasse;
        private System.Windows.Forms.TextBox BDDNomUtilisateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BoutonTestConnexion;
        private System.Windows.Forms.CheckBox EnregistrerInfosConnexionBDD;
        private System.Windows.Forms.NumericUpDown BDDPort;
    }
}
