using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class AdoEquipe : Ado
    {
        public static void createEquipe(Equipe uneEquipe)
        {
            open(); 
            string query = $"INSERT INTO equipe(nom_equipe) VALUES('{uneEquipe.Nom}')";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void getAll()
        {
            open();
            string query = $"SELECT * FROM equipe";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }
        public static void getEquipe(int id_equipe)
        {
            open();
            string query = $"SELECT * FROM equipe WHERE id={id_equipe}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void updateEquipe(int id_equipe, string nom_equipe)
        {
            open();
            string query = $"UPDATE equipe SET titre_tournois = {nom_equipe} WHERE id = {id_equipe}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void deleteEquipe(int id_equipe)
        {
            open();
            string query = $"DELETE * FROM equipe WHERE id = {id_equipe}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

    }
}
