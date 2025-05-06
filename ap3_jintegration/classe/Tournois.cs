using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.classe
{
    public class Tournois
    {
        private int id;
        private string nom_tournois;
        private DateTime date_tournois;
        private string lieu_tournois;
        private List<Epreuve> epreuve;
        private List<Equipe> equipe;

        public Tournois(string Nom_tournois, DateTime Date_tournois, string Lieu_tournois)
        {
            this.id = 0;
            this.Nom_tournois = Nom_tournois;
            this.Date_tournois = Date_tournois;
            this.Lieu_tournois = Lieu_tournois;
            this.Epreuve = new List<Epreuve>();
            this.Equipe = new List<Equipe>();
        }

        public Tournois(int Id,string Nom_tournois, DateTime Date_tournois, string Lieu_tournois)
        {
            this.id = Id;
            this.Nom_tournois = Nom_tournois;
            this.Date_tournois = Date_tournois;
            this.Lieu_tournois = Lieu_tournois;
            this.Epreuve = new List<Epreuve>();
            this.Equipe = new List<Equipe>();
        }


        // propriétés : 
        public int Id { get => id; }

        public string Nom_tournois { get => nom_tournois; set => nom_tournois = value; }
        public DateTime Date_tournois { get => date_tournois; set => date_tournois = value; }
        public string Lieu_tournois { get => lieu_tournois; set => lieu_tournois = value; }
        public List<Epreuve> Epreuve { get => epreuve; set => epreuve = value; }
        public List<Equipe> Equipe { get => equipe; set => equipe = value; }

        public override string ToString()
        {
            return this.Nom_tournois; 
        }
    }
}
