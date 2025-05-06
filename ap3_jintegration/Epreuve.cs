using ap3_jintegration.ado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap3_jintegration
{
    public partial class Epreuve : Form
    {
        public Epreuve()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstEpreuves.DataSource = AdoEpreuve.getAll();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr(e) ?", "Demande de confirmation",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                classe.Epreuve epreuve = lstEpreuves.SelectedItem as classe.Epreuve;
                AdoEpreuve.delete(epreuve.Id);
                lstEpreuves.DataSource = null;
                lstEpreuves.DataSource = AdoEpreuve.getAll();
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Boolean erreur = false;

            if (tbxDescription.Text == "")
            {
                erreur = true;
                lblErreurCreate.Visible = true;
                tbxDescription.BackColor = Color.Red;
                //créer label message erreur
                //mettre les textbox en rouge
            }

            if (tbxNom.Text == "")
            {
                erreur = true;
                lblErreurCreate.Visible = true;
                tbxNom.BackColor = Color.Red;
                //créer label message erreur
                //mettre les textbox en rouge
            }

            if (erreur == false)
            {
                classe.Epreuve epreuve = new classe.Epreuve(tbxNom.Text, 1, tbxDescription.Text);
                AdoEpreuve.create(epreuve);
                lstEpreuves.DataSource = null;
                lstEpreuves.DataSource = AdoEpreuve.getAll();
                tbxNom.Text = null;
                tbxDescription.Text = null;
            }

        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            tbxNom.BackColor = Color.White;
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {
            tbxDescription.BackColor = Color.White;
        }

        private void OpenWindow(object sender, EventArgs e) //bouton modifier qui ouvre la fenetre de modif
        {
            classe.Epreuve epreuve = lstEpreuves.SelectedItem as classe.Epreuve;
            updateEpreuveForm objupdateEpreuveForm = new updateEpreuveForm(epreuve);
            this.Hide();
            objupdateEpreuveForm.ShowDialog();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if (erreur  != false)
            //{
            //    Visible = false;
            //}
        }

        private void lstEpreuves_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe.Epreuve epreuve = lstEpreuves.SelectedItem as classe.Epreuve;
            if (epreuve != null)
            {
                lblAfficherNom.Text = epreuve.Nom;
                lblAfficherDescription.Text = epreuve.Description;
            }
        }
    }
}
