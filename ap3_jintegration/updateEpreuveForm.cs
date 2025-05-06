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
    public partial class updateEpreuveForm : Form
    {
        private classe.Epreuve epreuve;
        public updateEpreuveForm(classe.Epreuve uneEpreuve)
        {
            InitializeComponent();
            this.epreuve = uneEpreuve;
            //tbxIdEpreuve.Text = uneEpruve.Nom;
            tbxUpdateNom.Text = uneEpreuve.Nom;
            tbxUpdateDescription.Text = uneEpreuve.Description;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenWindow(object sender, EventArgs e) //bouton retour
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbxIdEpreuve_TextChanged(object sender, EventArgs e)
        {
            //tbxIdEpreuve.Text = id.ToString();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Boolean erreur = false;

            if (tbxUpdateNom.Text == "")
            {
                erreur = true;
                lblErreurUpdate.Visible = true;
                tbxUpdateNom.BackColor = Color.Red;
            }

            if (tbxUpdateDescription.Text == "")
            {
                erreur |= true;
                lblErreurUpdate.Visible = true;
                tbxUpdateDescription.BackColor = Color.Red;
            }

            if (erreur == false)
            {
                epreuve.Nom = tbxUpdateNom.Text;
                epreuve.Description = tbxUpdateDescription.Text;

                AdoEpreuve.update(epreuve);

                Epreuve objForm1 = new Epreuve();
                this.Hide();
                objForm1.ShowDialog();
            }

        }

        private void tbxUpdateNom_TextChanged(object sender, EventArgs e)
        {
            tbxUpdateNom.BackColor = Color.White;
        }

        private void tbxUpdateDescription_TextChanged(object sender, EventArgs e)
        {
            tbxUpdateDescription.BackColor = Color.White;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Epreuve objForm1 = new Epreuve();
            this.Hide();
            objForm1.ShowDialog();
        }
    }
}
