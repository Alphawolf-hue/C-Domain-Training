
namespace DesignPrinciples.SRP
{
    internal class Deposit
    {
        public void MakeDeposit(decimal amount)
        {
            Console.WriteLine($"Deposited: ${amount}");
        }
    }
}