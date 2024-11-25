﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    internal class AdoEpreuve : Ado
    {
        public static void create_tournois(string nom, string dte, string lieu)                                                 // surement changer les parametres a voir avec la class 
        {
            open();                                 // ouverture de la connexion a la bdd
            SqlCommand cmd = new SqlCommand();      // instanciation de la commande 
            cmd.Connection = connexion;
            cmd.CommandText = "INSERT INTO tournois (nom_tournois, date_tournois, lieu_tournois) VALUES (@nom,@dte,@lieu)";
            cmd.Parameters.AddWithValue(@nom, nom);
            cmd.Parameters.AddWithValue("@dte", dte);
            cmd.Parameters.AddWithValue(@lieu, lieu);
            cmd.ExecuteNonQuery();                  // pour executer la commande 
            close();                                // fermeture de la connexion a la bdd 

        }  //  formatage de la date et de l'heure :   String.Format("{dd/MM/yyyy hh:mm}",

        public static void getAll()
        {
            open();
            string query = $"SELECT * FROM tournois";
            SqlCommand cmd = new SqlCommand(query, connexion);
            cmd.ExecuteNonQuery();
            close();
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

        public static void update(string nom, DateTime date, int Id_tournois)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "UPDATE tournois SET nom_tournois = '@nom' WHERE id_tournois = @Id_tournois";
            cmd.Parameters.AddWithValue("@Id_tournois", Id_tournois);
            cmd.ExecuteNonQuery();
            close();
        }

        public static void delete(int Id_tournois)
        {
            open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = "DELETE FROM tournois WHERE id_tournois = @Id_tournois";
            cmd.Parameters.AddWithValue("@Id_tournois", Id_tournois);
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
