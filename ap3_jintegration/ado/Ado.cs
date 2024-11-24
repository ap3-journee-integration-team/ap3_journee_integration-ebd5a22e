using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap3_jintegration.ado
{
    public abstract class Ado
    {
        //user_name - ip/serveur - nom_base - password


        protected static SqlConnection connexion;

        public static void open()
        {

            string cs = $"Data Source = PC_TEH_LES_FOUS\\MSSQLSERVERCELIN; Initial Catalog = bd_ap3; Integrated Security = True";
            try
            {
                connexion = new SqlConnection(cs);
                connexion.Open();
                Console.WriteLine("Connexion ouverte");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected static void close()
        {
            if (connexion != null)
            {
                connexion.Close();
                Console.WriteLine("Connexion fermée");
            }
        }
    }
}
