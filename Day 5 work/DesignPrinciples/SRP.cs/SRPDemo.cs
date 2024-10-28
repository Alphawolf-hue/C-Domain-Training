using DesignPrinciples.SRP;

namespace DesignPrinciples.SRP
{
    internal class SRPDemo
    {
        public void SRPDemoMethod()
        {
            Deposit deposit = new();
            deposit.MakeDeposit(50000);
            CashWithdrawal cashWithdrawal = new();
            cashWithdrawal.Withdraw(2000);
            Statement statement = new();
            statement.PrintMonthlyStatement();
            statement.PrintYearlyStatement();
            statement.PrintMiniStatement();
        }
    }
}