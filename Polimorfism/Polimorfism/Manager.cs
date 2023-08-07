using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Manager : Employee
    {
        public Manager(string name, DateTime employmentDate) : base(name, employmentDate)
        {

        }

        public override double CalculateSalary()
        {
            var salary = base.CalculateSalary();
            var exparience = (int)(DateTime.Now - EmploymentDate).TotalDays/365;

            return salary + salary * 0.3 * exparience;
        }
    }
}
