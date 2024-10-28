
namespace DesignPrinciples.ISP
{
    public interface IBasicAccount
    {
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        void CheckBalance(int accID);
    }
    public interface IInvestmentAccount : IBasicAccount
    {
        void BuyShares(int numberOfShares);
        void SellShares(int numberOfShares);
    }
}