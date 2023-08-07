using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Accountant : Employee
    {
        public Contabil(string name, DateTime employmentDate) : base(name, employmentDate)
        {

        }

        public override double CalculateSalary()
        {
            var salary = base.CalculateSalary();
            var experience = (int)(DateTime.Now - EmploymentDate).TotalDays / 365;

            return salary + salary * 0.2 * experience;
        }
    }
}
