using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Angajat
    {
        public string Nume { get; private set; }

        public DateTime DataAngajarii { get; private set; }

        public Angajat(string nume, DateTime dataAngajarii) 
        {
            Nume = nume;
            DataAngajarii = dataAngajarii;
        }

        public virtual double CalculeazaSalariu()
        {
            return 10000;
        }

    }
}
