namespace DesignPrinciples.OCP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }
        public PermanentEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            decimal bonus = 5000;
            return salary + bonus;
        }
    }
}