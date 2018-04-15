namespace lot1.UserControlsParametres
{
    partial class UCFenParametresPreRemplissage
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
			this.label1 = new System.Windows.Forms.Label();
			this.DelimiteurDebutVariable = new System.Windows.Forms.TextBox();
			this.DelimiteurFinVariable = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TypeInformations = new System.Windows.Forms.ComboBox();
			this.SIRETprefere = new System.Windows.Forms.CheckBox();
			this.SIRENprefere = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.DelimiteurFinVariable);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.DelimiteurDebutVariable);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 110);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pré-remplissage manuel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Délimiteur de début de variable : ";
			// 
			// DelimiteurDebutVariable
			// 
			this.DelimiteurDebutVariable.Location = new System.Drawing.Point(202, 17);
			this.DelimiteurDebutVariable.Name = "DelimiteurDebutVariable";
			this.DelimiteurDebutVariable.Size = new System.Drawing.Size(88, 22);
			this.DelimiteurDebutVariable.TabIndex = 1;
			this.DelimiteurDebutVariable.Validating += new System.ComponentModel.CancelEventHandler(this.DelimiteurDebutVariable_Validating);
			// 
			// DelimiteurFinVariable
			// 
			this.DelimiteurFinVariable.Location = new System.Drawing.Point(202, 43);
			this.DelimiteurFinVariable.Name = "DelimiteurFinVariable";
			this.DelimiteurFinVariable.Size = new System.Drawing.Size(88, 22);
			this.DelimiteurFinVariable.TabIndex = 3;
			this.DelimiteurFinVariable.Validating += new System.ComponentModel.CancelEventHandler(this.DelimiteurFinVariable_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Délimiteur de fin de variable : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(338, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Modifier le délimiteur de début et de fin de variable nécessite la \r\nmodification" +
    " des modèles.";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SIRENprefere);
			this.groupBox2.Controls.Add(this.SIRETprefere);
			this.groupBox2.Controls.Add(this.TypeInformations);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(16, 133);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(364, 96);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pré-remplissage automatique";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Préférer les informations : ";
			// 
			// TypeInformations
			// 
			this.TypeInformations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeInformations.FormattingEnabled = true;
			this.TypeInformations.Items.AddRange(new object[] {
            "Normalisées",
            "Déclarées"});
			this.TypeInformations.Location = new System.Drawing.Point(171, 16);
			this.TypeInformations.Name = "TypeInformations";
			this.TypeInformations.Size = new System.Drawing.Size(167, 21);
			this.TypeInformations.TabIndex = 1;
			// 
			// SIRETprefere
			// 
			this.SIRETprefere.AutoSize = true;
			this.SIRETprefere.Location = new System.Drawing.Point(23, 46);
			this.SIRETprefere.Name = "SIRETprefere";
			this.SIRETprefere.Size = new System.Drawing.Size(154, 17);
			this.SIRETprefere.TabIndex = 2;
			this.SIRETprefere.Text = "SIRET à la place du SIREN";
			this.SIRETprefere.UseVisualStyleBackColor = true;
			// 
			// SIRENprefere
			// 
			this.SIRENprefere.AutoSize = true;
			this.SIRENprefere.Location = new System.Drawing.Point(24, 69);
			this.SIRENprefere.Name = "SIRENprefere";
			this.SIRENprefere.Size = new System.Drawing.Size(154, 17);
			this.SIRENprefere.TabIndex = 3;
			this.SIRENprefere.Text = "SIREN à la place du SIRET";
			this.SIRENprefere.UseVisualStyleBackColor = true;
			// 
			// UCFenParametresPreRemplissage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UCFenParametresPreRemplissage";
			this.Size = new System.Drawing.Size(397, 316);
			this.Load += new System.EventHandler(this.UCFenParametresPreRemplissage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DelimiteurFinVariable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DelimiteurDebutVariable;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox TypeInformations;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox SIRENprefere;
		private System.Windows.Forms.CheckBox SIRETprefere;
	}
}
