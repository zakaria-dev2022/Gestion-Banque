﻿using System;
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
            remplir();
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
            DataTable dataTable = Connection.ObtenirDonnees("SELECT cm.id,cl.*,cm.solde,cm.type_compte,cm.date_ouverture FROM comptes cm\r\nJOIN\r\n    clients cl ON cm.client_id = cl.id;");
            // Lier le DataTable au DataGridView
            tableau.DataSource = dataTable;

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte(int.Parse(txtnc.Text),float.Parse(txts.Text),txttc.Text,Convert.ToDateTime(txtd.Text));
            Compte.ajouterCompte(compte);
            nouveau();
            remplir();
            Ajouter.Enabled = true;
            Modifier.Enabled = false;
            Suprimer.Enabled = false;
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Connection.CloseConnection();
            if (MessageBox.Show("Voulez-vous suprimer se Compte?", "Gestion Banque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection.SuprimerDonner("compte", txtid.Text);
                MessageBox.Show("Supression Avec Success");
                remplir();
                Ajouter.Enabled = true;
                Modifier.Enabled = false;
                Suprimer.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Compte compte =new Compte(int.Parse(txtnc.Text), float.Parse(txts.Text), txttc.Text, Convert.ToDateTime(txtd.Text));
            int id = int.Parse(txtid.Text);
            Compte.ModifierCompte(compte, id);
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
                txtnc.Text = row.Cells["client_id"].Value.ToString();
                txts.Text = row.Cells["Solde"].Value.ToString();
                txttc.Text = row.Cells["type_compte"].Value.ToString();
                txtd.Text = row.Cells["date_ouverture"].Value.ToString();
                Ajouter.Enabled = false;
                Modifier.Enabled = true;
                Suprimer.Enabled = true;
            }
        }
    }
}
