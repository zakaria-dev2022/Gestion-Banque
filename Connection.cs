using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratique
{
    internal class Connection
    {
         SqlDataAdapter dataAdapter;
         DataTable dt;
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-G1088CP;Initial Catalog=banque;Integrated Security=True");
                
        // Méthode pour ouvrir la connexion
        public static void OpenConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Closed)
                {
                    cnx.Open();
                    Console.WriteLine("Connexion à la base de données ouverte avec succès.");
                    //MessageBox.Show("Connexion à la base de données ouverte avec succès.","Gestion Banque");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                MessageBox.Show("Erreur lors de l'ouverture de la connexion : " + ex.Message, "Gestion Banque");
            }
        }

        // Méthode pour fermer la connexion
        public static void CloseConnection()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    cnx.Close();
                    Console.WriteLine("Connexion à la base de données fermée avec succès.");
                   // MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Banque");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                MessageBox.Show("Connexion à la base de données fermer avec succès.", "Gestion Banque");
            }
        }


        public static void SuprimerDonner(string table, string id)
        {
            try
            {
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //connection = new SqlConnection(connectionString);
                {
                    cnx.Open();

                    string query = $"delete from {table} where id=  {id}";

                    using (SqlCommand command = new SqlCommand(query,cnx))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"La colonne {id} a été supprimée de la table {table} avec succès.");
                        MessageBox.Show($"La colonne {id} a été supprimée de la table {table} avec succès.", "Gestion Banque");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la suppression de la colonne : {ex.Message}");
                MessageBox.Show($"Erreur lors de la suppression de la colonne : {ex.Message}");
            }
        }



        public static DataTable ObtenirDonnees(string table)
        {
            DataTable dataTable = new DataTable();

            try
            {
                //using (SqlConnection connection = new SqlConnection(Connection.cnx))
                
                {
                    cnx.Open();

                    string query = $"SELECT * FROM {table}"; // Remplacez "VotreTable" par le nom réel de votre table

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, cnx))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération des données : {ex.Message}");
                MessageBox.Show($"Erreur lors de la récupération des données .{ex.Message}", "Gestion Banque");
            }

            return dataTable;
        }





       




    }
}
