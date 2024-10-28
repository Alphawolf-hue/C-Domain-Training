namespace DesignPrinciples.OCP
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int ID, string name)
        {
            this.ID = ID;
            this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return $"ID: {this.ID}\t Name:{this.Name}";
        }

    }
}