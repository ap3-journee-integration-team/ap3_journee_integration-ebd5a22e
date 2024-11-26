using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.classe
{
    public class Joueur
    {
        private string nom_joueur;
        private string prenom_joueur;
        private string classe_joueur;

        public Joueur(string nom_joueur, string prenom_joueur, string classe_joueur)
        {
            this.Nom_joueur = nom_joueur;
            this.Prenom_joueur = prenom_joueur;
            this.Classe_joueur = classe_joueur;
        }

        public Joueur()
        {
        }

        public string Nom_joueur { get => nom_joueur; set => nom_joueur = value; }
        public string Prenom_joueur { get => prenom_joueur; set => prenom_joueur = value; }
        public string Classe_joueur { get => classe_joueur; set => classe_joueur = value; }

    }
}
