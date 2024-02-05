using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratique
{
    public partial class formTransactions : Form
    {
        public formTransactions()
        {
            InitializeComponent();
        }

        private void formTransactions_Load(object sender, EventArgs e)
        {
            remplir();
        }


        void nouveau()
        {
            txtnc.Text = "";
            txtm.Text = "";
            txttt.Text = "";
            txtd.Text = "";
            txtnc.Focus();
        }

        void remplir()
        {
            Connection.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Connection.ObtenirDonnees("SELECT t.id,cm.*,t.montant,t.type_transactions,t.date_transactions FROM transactions t JOIN comptes cm ON t.compte_id = cm.id;");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(int.Parse(txtnc.Text), float.Parse(txtm.Text), txttt.Text, Convert.ToDateTime(txtd.Text));
            Transactions.ajouterTransactions(transactions);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Connection.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Transactions?", "Gestion Banque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection.SuprimerDonner("transactions", txtid.Text);
                MessageBox.Show("Supression Avec Success");
                remplir();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(int.Parse(txtnc.Text), float.Parse(txtm.Text), txttt.Text, Convert.ToDateTime(txtd.Text));
            int id = int.Parse(txtid.Text);
            Transactions.ModifierTransactions(transactions, id);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableau.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtnc.Text = row.Cells["compte_id"].Value.ToString();
                txtm.Text = row.Cells["montant"].Value.ToString();
                txttt.Text = row.Cells["type_transactions"].Value.ToString();
                txtd.Text = row.Cells["date_transactions"].Value.ToString();
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
        }
    }
}
