namespace ap3_jintegration
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTournois = new System.Windows.Forms.ListBox();
            this.tbxNomCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxLieuCreate = new System.Windows.Forms.TextBox();
            this.dteTournoisCreate = new System.Windows.Forms.DateTimePicker();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblErrorCreate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblErrorUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dteTournoisUpdate = new System.Windows.Forms.DateTimePicker();
            this.tbxLieuUpdate = new System.Windows.Forms.TextBox();
            this.tbxNomUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTournois
            // 
            this.lstTournois.FormattingEnabled = true;
            this.lstTournois.Location = new System.Drawing.Point(12, 12);
            this.lstTournois.Name = "lstTournois";
            this.lstTournois.Size = new System.Drawing.Size(198, 147);
            this.lstTournois.TabIndex = 0;
            this.lstTournois.SelectedIndexChanged += new System.EventHandler(this.lstTournois_SelectedIndexChanged);
            // 
            // tbxNomCreate
            // 
            this.tbxNomCreate.Location = new System.Drawing.Point(343, 12);
            this.tbxNomCreate.Name = "tbxNomCreate";
            this.tbxNomCreate.Size = new System.Drawing.Size(100, 20);
            this.tbxNomCreate.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(468, 160);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(135, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxLieuCreate
            // 
            this.tbxLieuCreate.Location = new System.Drawing.Point(343, 97);
            this.tbxLieuCreate.Name = "tbxLieuCreate";
            this.tbxLieuCreate.Size = new System.Drawing.Size(100, 20);
            this.tbxLieuCreate.TabIndex = 4;
            // 
            // dteTournoisCreate
            // 
            this.dteTournoisCreate.Location = new System.Drawing.Point(343, 53);
            this.dteTournoisCreate.Name = "dteTournoisCreate";
            this.dteTournoisCreate.Size = new System.Drawing.Size(200, 20);
            this.dteTournoisCreate.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(279, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(279, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date :";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(279, 104);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(36, 13);
            this.lblLieu.TabIndex = 8;
            this.lblLieu.Text = "Lieu : ";
            // 
            // lblErrorCreate
            // 
            this.lblErrorCreate.AutoSize = true;
            this.lblErrorCreate.Location = new System.Drawing.Point(279, 132);
            this.lblErrorCreate.Name = "lblErrorCreate";
            this.lblErrorCreate.Size = new System.Drawing.Size(227, 13);
            this.lblErrorCreate.TabIndex = 9;
            this.lblErrorCreate.Text = "Veuillez remplir les champs Nom, Date et Lieu. ";
            this.lblErrorCreate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(468, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblErrorUpdate
            // 
            this.lblErrorUpdate.AutoSize = true;
            this.lblErrorUpdate.Location = new System.Drawing.Point(279, 308);
            this.lblErrorUpdate.Name = "lblErrorUpdate";
            this.lblErrorUpdate.Size = new System.Drawing.Size(227, 13);
            this.lblErrorUpdate.TabIndex = 18;
            this.lblErrorUpdate.Text = "Veuillez remplir les champs Nom, Date et Lieu. ";
            this.lblErrorUpdate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lieu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom : ";
            // 
            // dteTournoisUpdate
            // 
            this.dteTournoisUpdate.Location = new System.Drawing.Point(343, 229);
            this.dteTournoisUpdate.Name = "dteTournoisUpdate";
            this.dteTournoisUpdate.Size = new System.Drawing.Size(200, 20);
            this.dteTournoisUpdate.TabIndex = 14;
            this.dteTournoisUpdate.ValueChanged += new System.EventHandler(this.dteTournoisUpdate_ValueChanged);
            // 
            // tbxLieuUpdate
            // 
            this.tbxLieuUpdate.Location = new System.Drawing.Point(343, 273);
            this.tbxLieuUpdate.Name = "tbxLieuUpdate";
            this.tbxLieuUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxLieuUpdate.TabIndex = 13;
            // 
            // tbxNomUpdate
            // 
            this.tbxNomUpdate.Location = new System.Drawing.Point(343, 188);
            this.tbxNomUpdate.Name = "tbxNomUpdate";
            this.tbxNomUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxNomUpdate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.lblErrorUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dteTournoisUpdate);
            this.Controls.Add(this.tbxLieuUpdate);
            this.Controls.Add(this.tbxNomUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblErrorCreate);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dteTournoisCreate);
            this.Controls.Add(this.tbxLieuCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbxNomCreate);
            this.Controls.Add(this.lstTournois);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTournois;
        private System.Windows.Forms.TextBox tbxNomCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxLieuCreate;
        private System.Windows.Forms.DateTimePicker dteTournoisCreate;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblErrorCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblErrorUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteTournoisUpdate;
        private System.Windows.Forms.TextBox tbxLieuUpdate;
        private System.Windows.Forms.TextBox tbxNomUpdate;
    }
}

