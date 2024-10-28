namespace DesignPrinciples.SRP
{
    internal class CashWithdrawal
    {
        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawn: ${amount}");
        }
    }
}