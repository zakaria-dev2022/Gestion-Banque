using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratique
{
    internal class Compte
    {
        public int clientId;
        public float solde;
        public string type_compte;
        public DateTime date_ouverture;
        


        public Compte(int clientId, float solde, string type_compte, DateTime date_ouverture)
        {
            this.clientId = clientId;
            this.solde = solde;
            this.type_compte = type_compte;
            this.date_ouverture = date_ouverture;
            
        }

        public static void ajouterCompte(Compte compte)
        {
            try
            {

                Connection.OpenConnection();

                string query = "INSERT INTO comptes (client_id, solde, type_compte, date_ouverture) VALUES (@clientId, @solde, @type_compte, @date_ouverture)";

                using (SqlCommand command = new SqlCommand(query, Connection.cnx))
                {
                    command.Parameters.AddWithValue("@clientId", compte.clientId);
                    command.Parameters.AddWithValue("@solde", compte.solde);
                    command.Parameters.AddWithValue("@type_compte", compte.type_compte);
                    command.Parameters.AddWithValue("@date_ouverture", compte.date_ouverture);

                    command.ExecuteNonQuery();
                    MessageBox.Show("ajoute avec success");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajoute des données : {ex.Message}");
                MessageBox.Show($"Erreur ajoute avec success: {ex.Message} ");
            }
        }

        public static void ModifierCompte(Compte compte, int id)
        {
            try
            {

                {
                    Connection.OpenConnection();

                    string query = "UPDATE comptes SET client_id = @clientId, solde = @solde, type_compte = @type_compte, date_ouverture = @date_ouverture WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, Connection.cnx))
                    {
                        command.Parameters.AddWithValue("@clientId", compte.clientId);
                        command.Parameters.AddWithValue("@solde", compte.solde);
                        command.Parameters.AddWithValue("@type_compte", compte.type_compte);
                        command.Parameters.AddWithValue("@date_ouverture", compte.date_ouverture);
                        command.Parameters.AddWithValue("@id", id);

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
