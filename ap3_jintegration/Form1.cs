using ap3_jintegration.ado;
using ap3_jintegration.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap3_jintegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTournois.DataSource = null;
            lstTournois.DataSource = AdoTournois.getAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        { 
            Tournois tournois = new Tournois(tbxNomCreate.Text, dteTournoisCreate.Value, tbxLieuCreate.Text);
            AdoTournois.create_tournois(tournois);
            lstTournois.DataSource = null;
            lstTournois.DataSource = AdoTournois.getAll();
        }

        
        private void lstTournois_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tournois tournois = lstTournois.SelectedItem as Tournois;
            if (tournois != null) {
                tbxNomUpdate.Text = tournois.Nom_tournois;
                dteTournoisUpdate.Value = tournois.Date_tournois;
                tbxLieuUpdate.Text = tournois.Lieu_tournois;
            }

            // permet de prendre l'item et d'afficher ses valeurs dans les textbox
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //envoyer les nouvelles valeurs en base de données
            Boolean erreur = false;
            Tournois tournois = lstTournois.SelectedItem as Tournois;

            if (tbxNomUpdate.Text == "")
            {
                erreur = true;
                lblErrorUpdate.Visible = true;
                tbxNomUpdate.BackColor = Color.Red;
            }

            if (dteTournoisUpdate.Value == null)
            {
                erreur |= true;
                lblErrorUpdate.Visible = true;
                dteTournoisUpdate.BackColor = Color.Red;
            }

            if (tbxLieuUpdate.Text == "")
            {
                erreur |= true;
                lblErrorUpdate.Visible = true;
                tbxLieuUpdate.BackColor = Color.Red;
            }

            if (erreur == false)
            {
                tournois.Nom_tournois = tbxNomUpdate.Text;
                tournois.Date_tournois = dteTournoisUpdate.Value;
                tournois.Lieu_tournois = tbxLieuUpdate.Text;
                
                AdoTournois.update(tournois);
                lstTournois.DataSource = AdoTournois.getAll();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tournois tournois = lstTournois.SelectedItem as Tournois;
            AdoTournois.delete(tournois);
            lstTournois.DataSource = AdoTournois.getAll(); 
        }


         //remise en blanc des tbx (en rouge quznd ils sont vides) 

         private void tbxNomUpdate_TextChanged(object sender, EventArgs e)
         {
            tbxNomUpdate.BackColor = Color.White;
         }

        private void tbxLieuUpdate_TextChanged(object sender, EventArgs e)
        {
            tbxLieuUpdate.BackColor = Color.White;
        }

        private void dteTournoisUpdate_ValueChanged(object sender, EventArgs e)
        {
            dteTournoisUpdate.BackColor = Color.White;
        }
    }
}
