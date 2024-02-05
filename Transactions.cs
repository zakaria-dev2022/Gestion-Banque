using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratique
{
    internal class Transactions
    {
        public int compteId;
        public string type_transactions;
        public float montant;
        public DateTime date_transactions;



        public Transactions( int compteId, float montant, string type_transactions, DateTime date_transactions)
        {
            this.compteId = compteId;
            this.montant = montant;
            this.type_transactions = type_transactions;
            this.date_transactions = date_transactions;

        }

        public static void ajouterTransactions(Transactions Transactions)
        {
            try
            {

                Connection.OpenConnection();

                string query = "INSERT INTO transactions (compte_id, montant, type_transactions, date_transactions) VALUES (@compte_id, @montant, @type_transactions, @date_transactions)";

                using (SqlCommand command = new SqlCommand(query, Connection.cnx))
                {
                    command.Parameters.AddWithValue("@compte_id", Transactions.compteId);
                    command.Parameters.AddWithValue("@montant", Transactions.montant);
                    command.Parameters.AddWithValue("@type_transactions", Transactions.type_transactions);
                    command.Parameters.AddWithValue("@date_transactions", Transactions.date_transactions);

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

        public static void ModifierTransactions(Transactions Transactions, int id)
        {
            try
            {

                {
                    Connection.OpenConnection();

                    string query = "UPDATE comptes SET compte_id = @compte_id, montant = @montant, type_transactions = @type_transactions, date_transactions = @date_transactions WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, Connection.cnx))
                    {
                        command.Parameters.AddWithValue("@compte_id", Transactions.compteId);
                        command.Parameters.AddWithValue("@montant", Transactions.montant);
                        command.Parameters.AddWithValue("@type_transactions", Transactions.type_transactions);
                        command.Parameters.AddWithValue("@date_transactions", Transactions.date_transactions);
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
