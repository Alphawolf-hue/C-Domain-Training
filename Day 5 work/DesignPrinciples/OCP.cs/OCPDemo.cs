using DesignPrinciples.OCP;

namespace DesignPrinciples.OCP
{
    internal class OCPDemo
    {
        public void OCPDemoMethod()
        {
            Employee emp1 = new PermanentEmployee(1, "Tejas");
            Employee emp2 = new TemporaryEmployee(2, "Skrillex");
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp1.CalculateBonus(1000));
            Console.WriteLine(emp2.ToString());
            Console.WriteLine(emp2.CalculateBonus(1000));
            Console.ReadLine();
        }
    }
}