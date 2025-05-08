using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class AdoEpreuve : Ado
    {
        public static void create(classe.Epreuve epreuve)                                                 // surement changer les parametres a voir avec la class 
        {
            open();                                 // ouverture de la connexion a la bdd
            SqlCommand cmd = new SqlCommand();      // instanciation de la commande 
            cmd.Connection = connexion;
            cmd.CommandText = "INSERT INTO epreuve (nom_epreuve,coeff,description) VALUES (@nom_epreuve,@coeff,@description)";
            cmd.Parameters.AddWithValue("@nom_epreuve", epreuve.Nom);
            cmd.Parameters.AddWithValue("@coeff", epreuve.Coeff);
            cmd.Parameters.AddWithValue("@description", epreuve.Description);
            cmd.ExecuteNonQuery();                  // pour executer la commande 
            close();                                // fermeture de la connexion a la bdd 

        }  //  formatage de la date et de l'heure :   String.Format("{dd/MM/yyyy hh:mm}",

        public static List<classe.Epreuve> getAll()
        {
            List<classe.Epreuve> epreuves = new List<classe.Epreuve>();
            open();
            string query = $"SELECT * FROM epreuve";
            SqlCommand cmd = new SqlCommand(query, connexion);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                epreuves.Add(new classe.Epreuve(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
            }

            close();
            return epreuves;

        }

        public static void getOne(classe.Epreuve epreuve)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM epreuve WHERE Id = @Id_epreuve";
            cmd.Parameters.AddWithValue("@Id_epreuve", epreuve.Id);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void update(classe.Epreuve epreuve)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "UPDATE epreuve SET nom_epreuve = @nom , description = @description WHERE Id_epreuve = @Id_epreuve";
            cmd.Parameters.AddWithValue("@nom", epreuve.Nom);
            cmd.Parameters.AddWithValue("@description", epreuve.Description);
            cmd.Parameters.AddWithValue("@Id_epreuve", epreuve.Id);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void delete(int Id_epreuve)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "DELETE FROM Epreuve WHERE id_epreuve = @Id_epreuve";
            cmd.Parameters.AddWithValue("@Id_epreuve", Id_epreuve);
            cmd.ExecuteNonQuery();
            close();

        }






        /*
        public static void create_epreuve(string nom, DateTime date)     // changer les parametres a voir avec la class 
        {
            open();   // ouverture de la connexion a la bdd
            string query = $"INSERT INTO epreuve (nom_epreuve, date_epreuve) VALUES ('{nom}','{date}')";   // requete SQL  A MODIFIER POUR PARAMETRER  
            SqlCommand cmd = new SqlCommand(query, connexion);     // instanciation de la commande 
            cmd.ExecuteNonQuery();    // pour executer la commande 
            close();    // fermeture de la connexion a la bdd 

        }

        public static void getAll()
        {
            open();
            string query = $"SELECT * FROM epreuve";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void getOne(int Id_epreuve)
        {
            open();
            string query = $"SELECT * FROM epreuve WHERE Id_epreuve = {Id_epreuve}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void update(string nom, DateTime date, int Id_epreuve)
        {
            open();
            string query = $"UPDATE epreuve SET nom_epreuve = '{nom}' WHERE Id_epreuve = {Id_epreuve}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void delete(int Id_epreuve)
        {
            open();
            string query = $"DELETE FROM epreuve WHERE Id_epreuve = {Id_epreuve}";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();

        } */






    }
}
