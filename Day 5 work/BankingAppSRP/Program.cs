namespace BankingAppSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit();
            CashWithdrawal withdrawal = new CashWithdrawal();
            Statement statement = new Statement();

            // Example usage with logic
            deposit.AddDeposit(500.00m);           // Deposit functionality
            deposit.AddDeposit(250.00m);

            withdrawal.ProcessWithdrawal(200.00m); // Withdrawal functionality
            withdrawal.ProcessWithdrawal(100.00m);

            // Adding transactions to Statement
            statement.AddTransactions(deposit.GetDeposits());
            statement.AddTransactions(withdrawal.GetWithdrawals());

            // Generate statements
            statement.GenerateMiniStatement();
            statement.GenerateMonthlyStatement();
            statement.GenerateYearlyStatement();

            Console.WriteLine("All functionalities executed.");
        }
    }
}
