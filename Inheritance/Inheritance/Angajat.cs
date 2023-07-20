using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Angajat
    {
        public string Nume { get; set; }

        public Angajat(string nume) 
        {
            Nume = nume;
        }

        public virtual void AfisareDetalii()
        {
            Console.WriteLine("Nume angajat: {0}", Nume);
        }
    }
}
