using ap3_jintegration.classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    public class adoEquipe : Ado
    {
        //open();
        //MySqlCommand cmd = new MySqlCommand();
        //cmd.Connection = connection; 
        //cmd.CommandText = "INSERT INTO robot(nom) VALUES(@nom)"; 
        //cmd.Parameters.AddWithValue("@nom", robot.getName()); 
        //cmd.Prepare() ; 
        //cmd.ExecuteNonQuery(); 
        //Console.WriteLine("combatant crée"); 
        //close();

        public static void createEquipe(Equipe uneEquipe)
        {
            open();
            //string query = $"INSERT INTO equipe(nom_equipe) VALUES('{uneEquipe.Nom}')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "INSERT INTO equipe(nom_equipe) VALUES(@nom_equipe)";
            cmd.Parameters.AddWithValue("@nom_equipe", Equipe.nom_equipe);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            close();
        }

        public static void getAll()
        {
            open();
            //string query = $"SELECT * FROM equipe";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM equipe";
            cmd.ExecuteNonQuery();
            close();
        }
        public static void getOneByID(int id_equipe)
        {
            open();
            //string query = $"SELECT * FROM equipe WHERE id={id_equipe}";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM equipe WHERE @id_equipe=id_equipe";
            cmd.Parameters.AddWithValue("@id_equipe", id_equipe);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void getOneByName(Equipe uneEquipe)
        {
            open();
            //string query = $"SELECT * FROM equipe WHERE id={id_equipe}";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM equipe WHERE @nom_equipe=nom_equipe";
            cmd.Parameters.AddWithValue("@nom_equipe", uneEquipe.Nom_equipe);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void updateEquipe(Equipe uneEquipe, int id_equipe)
        {
            open();
            //string query = $"UPDATE equipe SET titre_tournois = {nom_equipe} WHERE id = {id_equipe}";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "UPDATE equipe SET @nom_equipe=nom_equipe WHERE @id_equipe=id_equipe";
            cmd.Parameters.AddWithValue("@id_equipe", id_equipe);
            cmd.Parameters.AddWithValue("@nom_equipe", uneEquipe.Nom_equipe);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void deleteEquipe(int id_equipe)
        {
            open();
            //string query = $"DELETE * FROM equipe WHERE id = {id_equipe}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM equipe WHERE @id_equipe = id_equipe";
            cmd.Parameters.AddWithValue("@id_equipe", id_equipe);
            cmd.ExecuteNonQuery();
            close();
        }

    }
}
