using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingAppSRP
{
    class Statement
    {
        private List<Transaction> allTransactions = new List<Transaction>();

        public void AddTransactions(List<Transaction> transactions)
        {
            allTransactions.AddRange(transactions);
        }

        public void GenerateMiniStatement()
        {
            Console.WriteLine("Mini Statement (Last 5 Transactions):");
            var miniStatement = allTransactions
                .OrderByDescending(t => t.Date)
                .Take(5);
            DisplayTransactions(miniStatement);
        }

        public void GenerateMonthlyStatement()
        {
            Console.WriteLine("Monthly Statement:");
            var monthlyTransactions = allTransactions
                .Where(t => t.Date >= DateTime.Now.AddMonths(-1))
                .OrderByDescending(t => t.Date);
            DisplayTransactions(monthlyTransactions);
        }

        public void GenerateYearlyStatement()
        {
            Console.WriteLine("Yearly Statement:");
            var yearlyTransactions = allTransactions
                .Where(t => t.Date >= DateTime.Now.AddYears(-1))
                .OrderByDescending(t => t.Date);
            DisplayTransactions(yearlyTransactions);
        }

        private void DisplayTransactions(IEnumerable<Transaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"{transaction.Date}: {transaction.Type} of {transaction.Amount:C}");
            }
        }
    }
}
