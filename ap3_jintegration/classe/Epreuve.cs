using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.classe
{
    public class Epreuve
    {
        //nom coeff desc 
        private string nom;
        private int coeff;
        private string description;
        private Dictionary<Equipe,int> resultat;

        public void epreuve(string Nom, int Coeff, string Description)
        {
            this.nom = Nom;
            this.coeff = Coeff;
            this.description = Description;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Coeff { get => coeff; set => coeff = value; }
        public string Description { get => description; set => description = value; }
        public Dictionary<Equipe, int> Resultat { get => resultat; set => resultat = value; }
    }
}
