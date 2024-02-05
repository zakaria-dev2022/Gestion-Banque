using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pratique
{
    public partial class formClient : Form
    {
        
        public formClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplir();
        }
        void nouveau()
        {
            txtn.Text = "";
            txtp.Text="";
            txta.Text="";
            txtt.Text = "";
            txtn.Focus();
        }

        void remplir()
        {
            Connection.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Connection.ObtenirDonnees("select * from clients");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Client client = new Client(txtn.Text, txtp.Text, txta.Text, txtt.Text);
            Client.ajouterClient(client);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Client client = new Client(txtn.Text, txtp.Text, txta.Text, txtt.Text);
            int id = int.Parse(txtid.Text);
            Client.ModifierClient(client,id);
            nouveau();
           // Connection.CloseConnection();
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
                txtid.Text= row.Cells["id"].Value.ToString();
                txtn.Text = row.Cells["nom"].Value.ToString();
                txtp.Text = row.Cells["prenom"].Value.ToString();
                txta.Text = row.Cells["adresse"].Value.ToString();
                txtt.Text = row.Cells["tel"].Value.ToString();
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Connection.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se client?","Gestion Banque",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Connection.SuprimerDonner("clients", txtid.Text);
                MessageBox.Show("Supression Avec Success");
                //Connection.CloseConnection();
                remplir();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }

        }
    }
}
