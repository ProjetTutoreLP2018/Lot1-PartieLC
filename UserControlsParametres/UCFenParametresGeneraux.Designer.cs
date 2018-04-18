namespace lot1
{
    partial class UCFenParametresGeneraux
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
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.MillesimeAAnneeCourante = new System.Windows.Forms.CheckBox();
			this.DateADateDuJour = new System.Windows.Forms.CheckBox();
			this.FormatDate = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.AjouterItem = new System.Windows.Forms.Button();
			this.SupprimerItem = new System.Windows.Forms.Button();
			this.DescendreItem = new System.Windows.Forms.Button();
			this.MonterItem = new System.Windows.Forms.Button();
			this.ItemARajouter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ListeFormesJuridiques = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.MillesimeAAnneeCourante);
			this.groupBox1.Controls.Add(this.DateADateDuJour);
			this.groupBox1.Controls.Add(this.FormatDate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(18, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(361, 115);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dates, millésimes";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(70, 135);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(80, 17);
			this.checkBox3.TabIndex = 4;
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// MillesimeAAnneeCourante
			// 
			this.MillesimeAAnneeCourante.AutoSize = true;
			this.MillesimeAAnneeCourante.Location = new System.Drawing.Point(20, 85);
			this.MillesimeAAnneeCourante.Name = "MillesimeAAnneeCourante";
			this.MillesimeAAnneeCourante.Size = new System.Drawing.Size(221, 17);
			this.MillesimeAAnneeCourante.TabIndex = 3;
			this.MillesimeAAnneeCourante.Text = "Mettre le millésime à l\'année courante";
			this.MillesimeAAnneeCourante.UseVisualStyleBackColor = true;
			// 
			// DateADateDuJour
			// 
			this.DateADateDuJour.AutoSize = true;
			this.DateADateDuJour.Location = new System.Drawing.Point(20, 62);
			this.DateADateDuJour.Name = "DateADateDuJour";
			this.DateADateDuJour.Size = new System.Drawing.Size(196, 17);
			this.DateADateDuJour.TabIndex = 2;
			this.DateADateDuJour.Text = "Mettre les dates à la date du jour";
			this.DateADateDuJour.UseVisualStyleBackColor = true;
			// 
			// FormatDate
			// 
			this.FormatDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FormatDate.FormattingEnabled = true;
			this.FormatDate.Items.AddRange(new object[] {
            "Date courte",
            "Date longue"});
			this.FormatDate.Location = new System.Drawing.Point(114, 25);
			this.FormatDate.Name = "FormatDate";
			this.FormatDate.Size = new System.Drawing.Size(182, 21);
			this.FormatDate.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Format de date :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.AjouterItem);
			this.groupBox2.Controls.Add(this.SupprimerItem);
			this.groupBox2.Controls.Add(this.DescendreItem);
			this.groupBox2.Controls.Add(this.MonterItem);
			this.groupBox2.Controls.Add(this.ItemARajouter);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.ListeFormesJuridiques);
			this.groupBox2.Location = new System.Drawing.Point(18, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(361, 189);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Formes juridiques";
			// 
			// AjouterItem
			// 
			this.AjouterItem.Location = new System.Drawing.Point(247, 150);
			this.AjouterItem.Name = "AjouterItem";
			this.AjouterItem.Size = new System.Drawing.Size(75, 23);
			this.AjouterItem.TabIndex = 6;
			this.AjouterItem.Text = "Ajouter";
			this.AjouterItem.UseVisualStyleBackColor = true;
			this.AjouterItem.Click += new System.EventHandler(this.AjouterItem_Click);
			// 
			// SupprimerItem
			// 
			this.SupprimerItem.Location = new System.Drawing.Point(222, 94);
			this.SupprimerItem.Name = "SupprimerItem";
			this.SupprimerItem.Size = new System.Drawing.Size(92, 23);
			this.SupprimerItem.TabIndex = 5;
			this.SupprimerItem.Text = "Supprimer";
			this.SupprimerItem.UseVisualStyleBackColor = true;
			this.SupprimerItem.Click += new System.EventHandler(this.SupprimerItem_Click);
			// 
			// DescendreItem
			// 
			this.DescendreItem.Location = new System.Drawing.Point(222, 52);
			this.DescendreItem.Name = "DescendreItem";
			this.DescendreItem.Size = new System.Drawing.Size(92, 23);
			this.DescendreItem.TabIndex = 4;
			this.DescendreItem.Text = "Descendre";
			this.DescendreItem.UseVisualStyleBackColor = true;
			this.DescendreItem.Click += new System.EventHandler(this.DescendreItem_Click);
			// 
			// MonterItem
			// 
			this.MonterItem.Location = new System.Drawing.Point(222, 23);
			this.MonterItem.Name = "MonterItem";
			this.MonterItem.Size = new System.Drawing.Size(92, 23);
			this.MonterItem.TabIndex = 3;
			this.MonterItem.Text = "Monter";
			this.MonterItem.UseVisualStyleBackColor = true;
			this.MonterItem.Click += new System.EventHandler(this.MonterItem_Click);
			// 
			// ItemARajouter
			// 
			this.ItemARajouter.Location = new System.Drawing.Point(141, 150);
			this.ItemARajouter.Name = "ItemARajouter";
			this.ItemARajouter.Size = new System.Drawing.Size(100, 22);
			this.ItemARajouter.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Forme juridique : ";
			// 
			// ListeFormesJuridiques
			// 
			this.ListeFormesJuridiques.FormattingEnabled = true;
			this.ListeFormesJuridiques.Location = new System.Drawing.Point(20, 23);
			this.ListeFormesJuridiques.Name = "ListeFormesJuridiques";
			this.ListeFormesJuridiques.Size = new System.Drawing.Size(181, 121);
			this.ListeFormesJuridiques.TabIndex = 0;
			// 
			// UCFenParametresGeneraux
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCFenParametresGeneraux";
			this.Size = new System.Drawing.Size(397, 316);
			this.Load += new System.EventHandler(this.UCFenParametresGeneraux_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MillesimeAAnneeCourante;
        private System.Windows.Forms.CheckBox DateADateDuJour;
        private System.Windows.Forms.ComboBox FormatDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AjouterItem;
        private System.Windows.Forms.Button SupprimerItem;
        private System.Windows.Forms.Button DescendreItem;
        private System.Windows.Forms.Button MonterItem;
        private System.Windows.Forms.TextBox ItemARajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListeFormesJuridiques;
    }
}
