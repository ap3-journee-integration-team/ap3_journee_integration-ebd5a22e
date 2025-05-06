namespace ap3_jintegration
{
    partial class Epreuve
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
            this.lblAfficherDescription = new System.Windows.Forms.Label();
            this.lblAfficherNom = new System.Windows.Forms.Label();
            this.lblGetDescription = new System.Windows.Forms.Label();
            this.lblGetNom = new System.Windows.Forms.Label();
            this.lblErreurCreate = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblListe = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lstEpreuves = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAfficherDescription
            // 
            this.lblAfficherDescription.AutoSize = true;
            this.lblAfficherDescription.Location = new System.Drawing.Point(594, 128);
            this.lblAfficherDescription.Name = "lblAfficherDescription";
            this.lblAfficherDescription.Size = new System.Drawing.Size(41, 16);
            this.lblAfficherDescription.TabIndex = 27;
            this.lblAfficherDescription.Text = "descr";
            // 
            // lblAfficherNom
            // 
            this.lblAfficherNom.AutoSize = true;
            this.lblAfficherNom.Location = new System.Drawing.Point(597, 82);
            this.lblAfficherNom.Name = "lblAfficherNom";
            this.lblAfficherNom.Size = new System.Drawing.Size(33, 16);
            this.lblAfficherNom.TabIndex = 26;
            this.lblAfficherNom.Text = "nom";
            // 
            // lblGetDescription
            // 
            this.lblGetDescription.AutoSize = true;
            this.lblGetDescription.Location = new System.Drawing.Point(429, 128);
            this.lblGetDescription.Name = "lblGetDescription";
            this.lblGetDescription.Size = new System.Drawing.Size(159, 16);
            this.lblGetDescription.TabIndex = 25;
            this.lblGetDescription.Text = "Description de l\'épreuve :";
            // 
            // lblGetNom
            // 
            this.lblGetNom.AutoSize = true;
            this.lblGetNom.Location = new System.Drawing.Point(471, 82);
            this.lblGetNom.Name = "lblGetNom";
            this.lblGetNom.Size = new System.Drawing.Size(120, 16);
            this.lblGetNom.TabIndex = 24;
            this.lblGetNom.Text = "Nom de l\'épreuve :";
            // 
            // lblErreurCreate
            // 
            this.lblErreurCreate.AutoSize = true;
            this.lblErreurCreate.ForeColor = System.Drawing.Color.Red;
            this.lblErreurCreate.Location = new System.Drawing.Point(426, 198);
            this.lblErreurCreate.Name = "lblErreurCreate";
            this.lblErreurCreate.Size = new System.Drawing.Size(359, 16);
            this.lblErreurCreate.TabIndex = 23;
            this.lblErreurCreate.Text = "Les champs Nom et Description ne doivent pas être vides !!";
            this.lblErreurCreate.Visible = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(211, 344);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(171, 57);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.OpenWindow);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(15, 50);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(116, 16);
            this.lblListe.TabIndex = 21;
            this.lblListe.Text = "Epreuves créées :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(429, 307);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(159, 16);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description de l\'épreuve :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(468, 260);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(120, 16);
            this.lblNom.TabIndex = 18;
            this.lblNom.Text = "Nom de l\'épreuve :";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(594, 304);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(172, 22);
            this.tbxDescription.TabIndex = 17;
            this.tbxDescription.TextChanged += new System.EventHandler(this.tbxDescription_TextChanged);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(594, 355);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(101, 38);
            this.btnCreer.TabIndex = 19;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(594, 257);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 22);
            this.tbxNom.TabIndex = 16;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(18, 344);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(171, 57);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lstEpreuves
            // 
            this.lstEpreuves.FormattingEnabled = true;
            this.lstEpreuves.ItemHeight = 16;
            this.lstEpreuves.Location = new System.Drawing.Point(18, 82);
            this.lstEpreuves.Name = "lstEpreuves";
            this.lstEpreuves.Size = new System.Drawing.Size(364, 244);
            this.lstEpreuves.TabIndex = 14;
            this.lstEpreuves.SelectedIndexChanged += new System.EventHandler(this.lstEpreuves_SelectedIndexChanged);
            // 
            // Epreuve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAfficherDescription);
            this.Controls.Add(this.lblAfficherNom);
            this.Controls.Add(this.lblGetDescription);
            this.Controls.Add(this.lblGetNom);
            this.Controls.Add(this.lblErreurCreate);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lstEpreuves);
            this.Name = "Epreuve";
            this.Text = "Epreuve";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAfficherDescription;
        private System.Windows.Forms.Label lblAfficherNom;
        private System.Windows.Forms.Label lblGetDescription;
        private System.Windows.Forms.Label lblGetNom;
        private System.Windows.Forms.Label lblErreurCreate;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lstEpreuves;
    }
}