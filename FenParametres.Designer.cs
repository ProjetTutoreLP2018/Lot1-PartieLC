namespace lot1
{
    partial class FenParametres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoutonAnnuler = new System.Windows.Forms.Button();
            this.BoutonValider = new System.Windows.Forms.Button();
            this.Panneau = new System.Windows.Forms.Panel();
            this.ListeParametres = new System.Windows.Forms.ListBox();
            this.ReinitialiserParametres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoutonAnnuler
            // 
            this.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BoutonAnnuler.Location = new System.Drawing.Point(417, 324);
            this.BoutonAnnuler.Name = "BoutonAnnuler";
            this.BoutonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BoutonAnnuler.TabIndex = 2;
            this.BoutonAnnuler.Text = "Annuler";
            this.BoutonAnnuler.UseVisualStyleBackColor = true;
            // 
            // BoutonValider
            // 
            this.BoutonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonValider.Location = new System.Drawing.Point(502, 324);
            this.BoutonValider.Name = "BoutonValider";
            this.BoutonValider.Size = new System.Drawing.Size(80, 23);
            this.BoutonValider.TabIndex = 3;
            this.BoutonValider.Text = "Sauvegarder";
            this.BoutonValider.UseVisualStyleBackColor = true;
            this.BoutonValider.Click += new System.EventHandler(this.BoutonValider_Click);
            // 
            // Panneau
            // 
            this.Panneau.Location = new System.Drawing.Point(185, 2);
            this.Panneau.Name = "Panneau";
            this.Panneau.Size = new System.Drawing.Size(397, 316);
            this.Panneau.TabIndex = 4;
            // 
            // ListeParametres
            // 
            this.ListeParametres.FormattingEnabled = true;
            this.ListeParametres.Items.AddRange(new object[] {
            "Général",
            "Emplacements",
            "Base de données",
            "Pré-remplissage"});
            this.ListeParametres.Location = new System.Drawing.Point(3, 2);
            this.ListeParametres.Name = "ListeParametres";
            this.ListeParametres.Size = new System.Drawing.Size(176, 316);
            this.ListeParametres.TabIndex = 5;
            this.ListeParametres.Click += new System.EventHandler(this.ListeParametres_Click);
            // 
            // ReinitialiserParametres
            // 
            this.ReinitialiserParametres.Location = new System.Drawing.Point(3, 324);
            this.ReinitialiserParametres.Name = "ReinitialiserParametres";
            this.ReinitialiserParametres.Size = new System.Drawing.Size(80, 23);
            this.ReinitialiserParametres.TabIndex = 6;
            this.ReinitialiserParametres.Text = "Réinitialiser";
            this.ReinitialiserParametres.UseVisualStyleBackColor = true;
            this.ReinitialiserParametres.Click += new System.EventHandler(this.ReinitialiserParametres_Click);
            // 
            // FenParametres
            // 
            this.AcceptButton = this.BoutonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BoutonAnnuler;
            this.ClientSize = new System.Drawing.Size(589, 357);
            this.Controls.Add(this.ReinitialiserParametres);
            this.Controls.Add(this.ListeParametres);
            this.Controls.Add(this.Panneau);
            this.Controls.Add(this.BoutonValider);
            this.Controls.Add(this.BoutonAnnuler);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FenParametres";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.FenParametres_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BoutonAnnuler;
        private System.Windows.Forms.Button BoutonValider;
        private System.Windows.Forms.Panel Panneau;
        private System.Windows.Forms.ListBox ListeParametres;
        private System.Windows.Forms.Button ReinitialiserParametres;
    }
}