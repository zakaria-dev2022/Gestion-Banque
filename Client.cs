using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratique
{
    
    internal class Client
    {
        // public int clientId;
        public string nom;
        public string prenom;
        public string adresse;
        public string tel;
        

        public Client( string nom, string prenom, string adresse, string tel)
        {
            //this.clientId = clientId;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.tel = tel;
        }

        public static void ajouterClient(Client client)
        {
            try
            {
               
                    Connection.OpenConnection();

                    string query = "INSERT INTO clients (nom, prenom, adresse, tel) VALUES (@Nom, @Prenom, @Adresse, @Tel)";

                    using (SqlCommand command = new SqlCommand(query,Connection.cnx))
                    {
                        command.Parameters.AddWithValue("@Nom", client.nom);
                        command.Parameters.AddWithValue("@Prenom", client.prenom);
                        command.Parameters.AddWithValue("@Adresse", client.adresse);
                        command.Parameters.AddWithValue("@Tel", client.tel);

                        command.ExecuteNonQuery();
                        MessageBox.Show("ajoute avec success");
                    }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout des données : {ex.Message}");
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void ModifierClient(Client client, int id)
        {
            try
            {
                
                {
                    Connection.OpenConnection();

                    string query = "UPDATE clients SET nom = @Nom, prenom = @Prenom, adresse = @Adresse, tel = @Tel WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, Connection.cnx))
                    {
                        command.Parameters.AddWithValue("@Nom", client.nom);
                        command.Parameters.AddWithValue("@Prenom", client.prenom);
                        command.Parameters.AddWithValue("@Adresse", client.adresse);
                        command.Parameters.AddWithValue("@Tel", client.tel);
                        command.Parameters.AddWithValue("@id",id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuée avec succès");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la modification des données : {ex.Message}");
                MessageBox.Show($"Erreur lors de la modification des données : {ex.Message}");
            }
        }











    }
}
