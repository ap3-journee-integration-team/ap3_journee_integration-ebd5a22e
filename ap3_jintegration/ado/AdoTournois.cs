using ap3_jintegration.classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class AdoTournois : Ado
    {
        public static void create_tournois(Tournois tournois)
        {
            open();                                 // ouverture de la connexion a la bdd
            SqlCommand cmd = new SqlCommand();      // instanciation de la commande 
            cmd.Connection = connexion;
            cmd.CommandText = "INSERT INTO tournois (nom_tournois, date_tournois, lieu_tournois) VALUES (@nom,@dte,@lieu)";
            cmd.Parameters.AddWithValue("@nom",tournois.Nom_tournois);
            cmd.Parameters.AddWithValue("@dte", tournois.Date_tournois);
            cmd.Parameters.AddWithValue("@lieu", tournois.Lieu_tournois);
            cmd.ExecuteNonQuery();                  // pour executer la commande 
            close();                                // fermeture de la connexion a la bdd 

        }  //  formatage de la date et de l'heure :   String.Format("{dd/MM/yyyy hh:mm}",

        public static List<Tournois> getAll()
        {
            List<Tournois> tournois = new List <Tournois>();
            open();
            string query = $"SELECT * FROM tournois";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                tournois.Add(new Tournois(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3)));
            }
            close();
            return tournois;

        }

        public static void getOne(int Id_tournois)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "SELECT * FROM tournois WHERE id_tournois = @Id_tournois";
            cmd.Parameters.AddWithValue("@Id_tournois", Id_tournois);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void update(Tournois tournois)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "UPDATE tournois SET nom_tournois = @nom, date_tournois = @dte, lieu_tournois = @lieu WHERE id_tournois = @Id_tournois";
            cmd.Parameters.AddWithValue("@Id_tournois", tournois.Id);
            cmd.Parameters.AddWithValue("@nom", tournois.Nom_tournois);
            cmd.Parameters.AddWithValue("@dte", tournois.Date_tournois);
            cmd.Parameters.AddWithValue("@lieu", tournois.Lieu_tournois);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void delete(Tournois tournois)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "DELETE FROM tournois WHERE id_tournois = @Id_tournois";
            cmd.Parameters.AddWithValue("@Id_tournois", tournois.Id);
            cmd.ExecuteNonQuery();
            close();

        }
    }
}
