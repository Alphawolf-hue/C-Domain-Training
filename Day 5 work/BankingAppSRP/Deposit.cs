using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingAppSRP
{
    class Deposit
    {
        private List<Transaction> depositTransactions = new List<Transaction>();

        public void AddDeposit(decimal amount)
        {
            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Type = "Deposit"
            };
            depositTransactions.Add(transaction);
            Console.WriteLine($"Deposit successful: Amount - {amount:C}");
        }

        public List<Transaction> GetDeposits()
        {
            return depositTransactions;
        }
    }
}
