using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Employee
    {
        private readonly double BASE_SALARY = 10000;

        public string Name { get; private set; }

        public DateTime EmploymentDate { get; private set; }

        public Employee(string name, DateTime employmentDate) 
        {
            Name = name;
            EmploymentDate = employmentDate;
        }

        public virtual double CalculateSalary()
        {
            return BASE_SALARY;
        }

    }
}
