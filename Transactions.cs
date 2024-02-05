using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratique
{
    internal class Transactions
    {
        public int transactionsId;
        public int compteId;
        public string type_transactions;
        public float montant;
        public DateTime date_transactions;



        public Transactions(int transactionsId, int compteId, float montant, string type_transactions, DateTime date_transactions)
        {
            this.transactionsId = transactionsId;
            this.compteId = compteId;
            this.type_transactions = type_transactions;
            this.montant = montant;
            this.date_transactions = date_transactions;

        }
    }
}
