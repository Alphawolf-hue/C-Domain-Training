using System.Globalization;

namespace DesignPrinciples.ISP
{
    internal class SavingsAccount : IBasicAccount
    {
        public int AccountID { get; set; }
        public decimal Balance { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount < 0 || amount > Balance)
            {
                Console.WriteLine("Cannot withdraw");
            }
            Balance -= amount;
            Console.WriteLine($"{amount.ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"))} withdrawn, current balance: {Balance:C}");

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

    }
}