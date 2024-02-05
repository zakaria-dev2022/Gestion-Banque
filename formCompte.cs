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
    public partial class formCompte : Form
    {
        public formCompte()
        {
            InitializeComponent();
        }

        private void formCompte_Load(object sender, EventArgs e)
        {

        }
        void nouveau()
        {
            txtnc.Text = "";
            txts.Text = "";
            txttc.Text = "";
            txtd.Text = "";
            txtnc.Focus();
        }

        void remplir()
        {
            Connection.CloseConnection();
            //Connection dbOperations = new Connection();
            DataTable dataTable = Connection.ObtenirDonnees("comptes");

            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte(int.Parse(txtnc.Text),float.Parse(txts.Text),txttc.Text,Convert.ToDateTime(txtd.Text));
            Compte.ajouterCompte(compte);
            nouveau();
            //Connection.CloseConnection();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }
    }
}
