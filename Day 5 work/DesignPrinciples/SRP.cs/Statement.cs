namespace DesignPrinciples.SRP
{
    internal class Statement
    {
        public void PrintMiniStatement()
        {
            Console.WriteLine("Mini Statement printed.");
        }

        public void PrintMonthlyStatement()
        {
            Console.WriteLine("Monthly Statement printed.");
        }

        public void PrintYearlyStatement()
        {
            Console.WriteLine("Yearly Statement printed.");
        }
    }
}