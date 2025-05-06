namespace ap3_jintegration
{
    partial class updateEpreuveForm
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
            this.lblErreurUpdate = new System.Windows.Forms.Label();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateNom = new System.Windows.Forms.Label();
            this.tbxUpdateDescription = new System.Windows.Forms.TextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.tbxUpdateNom = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblModifier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErreurUpdate
            // 
            this.lblErreurUpdate.AutoSize = true;
            this.lblErreurUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblErreurUpdate.Location = new System.Drawing.Point(250, 97);
            this.lblErreurUpdate.Name = "lblErreurUpdate";
            this.lblErreurUpdate.Size = new System.Drawing.Size(359, 16);
            this.lblErreurUpdate.TabIndex = 20;
            this.lblErreurUpdate.Text = "Les champs Nom et Description ne doivent pas être vides !!";
            this.lblErreurUpdate.Visible = false;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(177, 202);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(159, 16);
            this.lblUpdateDescription.TabIndex = 19;
            this.lblUpdateDescription.Text = "Description de l\'épreuve :";
            // 
            // lblUpdateNom
            // 
            this.lblUpdateNom.AutoSize = true;
            this.lblUpdateNom.Location = new System.Drawing.Point(216, 151);
            this.lblUpdateNom.Name = "lblUpdateNom";
            this.lblUpdateNom.Size = new System.Drawing.Size(120, 16);
            this.lblUpdateNom.TabIndex = 18;
            this.lblUpdateNom.Text = "Nom de l\'épreuve :";
            // 
            // tbxUpdateDescription
            // 
            this.tbxUpdateDescription.Location = new System.Drawing.Point(342, 202);
            this.tbxUpdateDescription.Name = "tbxUpdateDescription";
            this.tbxUpdateDescription.Size = new System.Drawing.Size(172, 22);
            this.tbxUpdateDescription.TabIndex = 17;
            this.tbxUpdateDescription.TextChanged += new System.EventHandler(this.tbxUpdateDescription_TextChanged);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(298, 255);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(216, 38);
            this.btnSauvegarder.TabIndex = 16;
            this.btnSauvegarder.Text = "Sauvegarder les changements";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // tbxUpdateNom
            // 
            this.tbxUpdateNom.Location = new System.Drawing.Point(342, 151);
            this.tbxUpdateNom.Name = "tbxUpdateNom";
            this.tbxUpdateNom.Size = new System.Drawing.Size(100, 22);
            this.tbxUpdateNom.TabIndex = 15;
            this.tbxUpdateNom.TextChanged += new System.EventHandler(this.tbxUpdateNom_TextChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(46, 44);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "<-  Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblModifier
            // 
            this.lblModifier.AutoSize = true;
            this.lblModifier.Location = new System.Drawing.Point(336, 51);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(133, 16);
            this.lblModifier.TabIndex = 13;
            this.lblModifier.Text = "Modifier une épreuve";
            // 
            // updateEpreuveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreurUpdate);
            this.Controls.Add(this.lblUpdateDescription);
            this.Controls.Add(this.lblUpdateNom);
            this.Controls.Add(this.tbxUpdateDescription);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.tbxUpdateNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblModifier);
            this.Name = "updateEpreuveForm";
            this.Text = "updateEpreuveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreurUpdate;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateNom;
        private System.Windows.Forms.TextBox tbxUpdateDescription;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox tbxUpdateNom;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblModifier;
    }
}