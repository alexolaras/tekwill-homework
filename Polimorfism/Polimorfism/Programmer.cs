using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Programmer : Employee
    {
        public List<string> ProgrammingLanguages { get; set; }

        public Programmer(string name, DateTime employmentDate, List<string> languages) : base(name, employmentDate) 
        {
            ProgrammingLanguages = languages;
        }

        public void AddLanguage(string limbaj)
        {
            ProgrammingLanguages.Add(limbaj);
        }

        public override double CalculateSalary()
        {
            var baseSalary = base.CalculateSalary();
            double finalSalary = baseSalary;

            foreach (string language in ProgrammingLanguages)
            {
                if(language.ToUpper() == "C#")
                {
                    finalSalary += baseSalary * 4;
                }
                else
                {
                    finalSalary += baseSalary * 0.5;
                }
            }
            return finalSalary;
        }
    }
}
