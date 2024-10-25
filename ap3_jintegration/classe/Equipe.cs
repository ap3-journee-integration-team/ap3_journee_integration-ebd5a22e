using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.classe
{
    abstract class Equipe
    {
        private string nom_equipe;

        public Equipe(string nom_equipe)
        {
            this.Nom_equipe = nom_equipe;
        }

        protected Equipe()
        {
        }

        public string Nom_equipe { get => nom_equipe; set => nom_equipe = value; }
    }
}
