namespace ap3_jintegration
{
    partial class AssocierEquipeTournois
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
            this.lstTournois = new System.Windows.Forms.ListBox();
            this.lstEpreuves = new System.Windows.Forms.ListBox();
            this.lstEpreuvesAssociees = new System.Windows.Forms.ListBox();
            this.lblEpreuves = new System.Windows.Forms.Label();
            this.lblEpreuvesAssociees = new System.Windows.Forms.Label();
            this.btnAssocier = new System.Windows.Forms.Button();
            this.btnDesassocier = new System.Windows.Forms.Button();
            this.btnSaveAssociation = new System.Windows.Forms.Button();
            this.btnRetourTournois = new System.Windows.Forms.Button();
            this.btnRetourEpreuves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTournois
            // 
            this.lstTournois.FormattingEnabled = true;
            this.lstTournois.ItemHeight = 16;
            this.lstTournois.Items.AddRange(new object[] {
            "Journée d\'intégration études sup",
            "Journée d\'intégration lycée"});
            this.lstTournois.Location = new System.Drawing.Point(24, 57);
            this.lstTournois.Name = "lstTournois";
            this.lstTournois.Size = new System.Drawing.Size(200, 292);
            this.lstTournois.TabIndex = 0;
            this.lstTournois.SelectedIndexChanged += new System.EventHandler(this.lstTournois_SelectedIndexChanged);
            // 
            // lstEpreuves
            // 
            this.lstEpreuves.FormattingEnabled = true;
            this.lstEpreuves.ItemHeight = 16;
            this.lstEpreuves.Items.AddRange(new object[] {
            "babyfoot géant",
            "jeux de société",
            "jeux en bois",
            "pétanque"});
            this.lstEpreuves.Location = new System.Drawing.Point(258, 57);
            this.lstEpreuves.Name = "lstEpreuves";
            this.lstEpreuves.Size = new System.Drawing.Size(200, 292);
            this.lstEpreuves.TabIndex = 1;
            this.lstEpreuves.SelectedIndexChanged += new System.EventHandler(this.lstEpreuves_SelectedIndexChanged);
            // 
            // lstEpreuvesAssociees
            // 
            this.lstEpreuvesAssociees.FormattingEnabled = true;
            this.lstEpreuvesAssociees.ItemHeight = 16;
            this.lstEpreuvesAssociees.Items.AddRange(new object[] {
            "balle aux prisonniers "});
            this.lstEpreuvesAssociees.Location = new System.Drawing.Point(571, 57);
            this.lstEpreuvesAssociees.Name = "lstEpreuvesAssociees";
            this.lstEpreuvesAssociees.Size = new System.Drawing.Size(200, 292);
            this.lstEpreuvesAssociees.TabIndex = 2;
            // 
            // lblEpreuves
            // 
            this.lblEpreuves.AutoSize = true;
            this.lblEpreuves.Location = new System.Drawing.Point(255, 25);
            this.lblEpreuves.Name = "lblEpreuves";
            this.lblEpreuves.Size = new System.Drawing.Size(127, 16);
            this.lblEpreuves.TabIndex = 3;
            this.lblEpreuves.Text = "Liste des épreuves :";
            // 
            // lblEpreuvesAssociees
            // 
            this.lblEpreuvesAssociees.AutoSize = true;
            this.lblEpreuvesAssociees.Location = new System.Drawing.Point(568, 25);
            this.lblEpreuvesAssociees.Name = "lblEpreuvesAssociees";
            this.lblEpreuvesAssociees.Size = new System.Drawing.Size(193, 16);
            this.lblEpreuvesAssociees.TabIndex = 4;
            this.lblEpreuvesAssociees.Text = "Liste des épreuves associées :";
            // 
            // btnAssocier
            // 
            this.btnAssocier.Location = new System.Drawing.Point(475, 176);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(75, 23);
            this.btnAssocier.TabIndex = 5;
            this.btnAssocier.Text = "->";
            this.btnAssocier.UseVisualStyleBackColor = true;
            // 
            // btnDesassocier
            // 
            this.btnDesassocier.Location = new System.Drawing.Point(475, 221);
            this.btnDesassocier.Name = "btnDesassocier";
            this.btnDesassocier.Size = new System.Drawing.Size(75, 23);
            this.btnDesassocier.TabIndex = 6;
            this.btnDesassocier.Text = "<-";
            this.btnDesassocier.UseVisualStyleBackColor = true;
            // 
            // btnSaveAssociation
            // 
            this.btnSaveAssociation.Location = new System.Drawing.Point(622, 367);
            this.btnSaveAssociation.Name = "btnSaveAssociation";
            this.btnSaveAssociation.Size = new System.Drawing.Size(109, 60);
            this.btnSaveAssociation.TabIndex = 7;
            this.btnSaveAssociation.Text = "Enregistrer";
            this.btnSaveAssociation.UseVisualStyleBackColor = true;
            // 
            // btnRetourTournois
            // 
            this.btnRetourTournois.Location = new System.Drawing.Point(24, 377);
            this.btnRetourTournois.Name = "btnRetourTournois";
            this.btnRetourTournois.Size = new System.Drawing.Size(162, 23);
            this.btnRetourTournois.TabIndex = 8;
            this.btnRetourTournois.Text = "<- Liste des tournois";
            this.btnRetourTournois.UseVisualStyleBackColor = true;
            // 
            // btnRetourEpreuves
            // 
            this.btnRetourEpreuves.Location = new System.Drawing.Point(24, 406);
            this.btnRetourEpreuves.Name = "btnRetourEpreuves";
            this.btnRetourEpreuves.Size = new System.Drawing.Size(162, 23);
            this.btnRetourEpreuves.TabIndex = 9;
            this.btnRetourEpreuves.Text = "<- Liste des épreuves";
            this.btnRetourEpreuves.UseVisualStyleBackColor = true;
            // 
            // AssocierEquipeTournois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetourEpreuves);
            this.Controls.Add(this.btnRetourTournois);
            this.Controls.Add(this.btnSaveAssociation);
            this.Controls.Add(this.btnDesassocier);
            this.Controls.Add(this.btnAssocier);
            this.Controls.Add(this.lblEpreuvesAssociees);
            this.Controls.Add(this.lblEpreuves);
            this.Controls.Add(this.lstEpreuvesAssociees);
            this.Controls.Add(this.lstEpreuves);
            this.Controls.Add(this.lstTournois);
            this.Name = "AssocierEquipeTournois";
            this.Text = "AssocierEquipeTournois";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTournois;
        private System.Windows.Forms.ListBox lstEpreuves;
        private System.Windows.Forms.ListBox lstEpreuvesAssociees;
        private System.Windows.Forms.Label lblEpreuves;
        private System.Windows.Forms.Label lblEpreuvesAssociees;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.Button btnDesassocier;
        private System.Windows.Forms.Button btnSaveAssociation;
        private System.Windows.Forms.Button btnRetourTournois;
        private System.Windows.Forms.Button btnRetourEpreuves;
    }
}