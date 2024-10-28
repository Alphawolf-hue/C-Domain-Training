namespace DesignPrinciples.ISP
{
    internal class InvestmentAccount : IInvestmentAccount
    {
        public int AccountID { get; set; }
        public decimal Balance { get; set; }
        public int TotalShares { get; set; }
        public void Withdraw(decimal amount)
        {
            if (amount < 0 || amount > Balance)
            {
                Console.WriteLine("Cannot withdraw");
            }
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn, current balance: {Balance:C}");

        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited, current balance: {Balance:C}");

        }
        public void CheckBalance(int accID)
        {
            Console.WriteLine($"Your balance is {Balance:C}");
        }

        public void BuyShares(int numberOfShares)
        {
            TotalShares += numberOfShares;
            Console.WriteLine($"Shares Bought: {numberOfShares}, current total shares: {TotalShares}");

        }
        public void SellShares(int numberOfShares)
        {
            TotalShares -= numberOfShares;
            Console.WriteLine($"Shares Sold: {numberOfShares}, current total shares: {TotalShares}");
        }

    }
}
