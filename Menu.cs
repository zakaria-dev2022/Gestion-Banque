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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            formClient formClient = new formClient();
            formClient.ShowDialog();
            this.Hide();
        }

        private void btn_compte_Click(object sender, EventArgs e)
        {
            formCompte formCompte = new formCompte();   
            formCompte.ShowDialog();
            this.Hide();
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            formTransactions formTransactions = new formTransactions();
            formTransactions.ShowDialog();
            this.Hide();
        }
    }
}
