using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ap3_jintegration.classe
{
    public class Equipe
    {
        private string nom_equipe;
        private List<Joueur> joueur;
        private Dictionary<Epreuve, int> resultat; //création d'un dictionnaire vide avec juste des contraintes de forme : attend un type Epreuve et un type int
        // ajouter methode .add dans la classe pas la bdd

        public Equipe()
        {
        }

        public Equipe(string nom_equipe, List<Joueur> joueur)
        {
            this.nom_equipe = nom_equipe;
            this.joueur = joueur;
            this.resultat = new Dictionary<Epreuve, int>();
        }

        public string Nom_equipe { get => nom_equipe; set => nom_equipe = value; }
        public List<Joueur> Joueur { get => joueur; set => joueur = value; }
        internal Dictionary<Epreuve, int> Resultat { get => resultat; set => resultat = value; }

        //public void inscrireEp (Epreuve ep)
        //{
        //    if (resultat.ContainsKey(ep))
        //    {

        //    }
        //}


        //public void addScore(Epreuve ep, int scoreEp)
        //{
        //    if (resultat.ContainsKey(ep))
        //    { 
        //        for ()
        //    }
        //}


    }
}
