using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class AdoJoueur : Ado
    {
        public static void getAll()
        {
            open();
            string query = $"SELECT * FROM Joueur";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }
    }
}
