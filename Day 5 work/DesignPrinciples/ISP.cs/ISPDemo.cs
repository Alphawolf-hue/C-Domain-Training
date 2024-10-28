using DesignPrinciples.ISP;

namespace DesignPrinciples.ISP
{
    internal class ISPDemo
    {
        public void ISPDemoMethod()
        {
            Console.WriteLine("\n---------------------- Savings Account ------------------------");
            IBasicAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(5000);
            savingsAccount.CheckBalance(1);
            savingsAccount.Withdraw(2000);
            savingsAccount.CheckBalance(1);

            Console.WriteLine("\n---------------------- Investment Account ------------------------");
            IInvestmentAccount investmentAccount = new InvestmentAccount();
            investmentAccount.Deposit(50000);
            investmentAccount.CheckBalance(1);
            investmentAccount.Withdraw(2000);
            investmentAccount.CheckBalance(1);
            investmentAccount.BuyShares(100);
            investmentAccount.SellShares(80);
        }
    }
}
