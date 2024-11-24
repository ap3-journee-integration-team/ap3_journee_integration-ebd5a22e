using ap3_jintegration.classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class adoJoueur : Ado 
    {
        public static void getAll()
        {
            open();
            //string query = $"SELECT * FROM Joueur";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM joueur";
            cmd.ExecuteNonQuery();
            close();
        }
    }
}
