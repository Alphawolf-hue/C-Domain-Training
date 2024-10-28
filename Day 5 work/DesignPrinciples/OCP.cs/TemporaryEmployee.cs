using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.OCP
{
    internal class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            decimal bonus = 2000;
            return salary + bonus;
        }
    }
}
