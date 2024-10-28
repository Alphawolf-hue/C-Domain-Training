using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingAppSRP
{
    class CashWithdrawal
    {
        private List<Transaction> withdrawalTransactions = new List<Transaction>();
        private decimal balance = 1000.00m; // Example initial balance

        public void ProcessWithdrawal(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
                return;
            }

            var transaction = new Transaction
            {
                Date = DateTime.Now,
                Amount = -amount,
                Type = "Withdrawal"
            };
            balance -= amount;
            withdrawalTransactions.Add(transaction);
            Console.WriteLine($"Withdrawal successful: Amount - {amount:C}");
        }

        public List<Transaction> GetWithdrawals()
        {
            return withdrawalTransactions;
        }
    }
}
