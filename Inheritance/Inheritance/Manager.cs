using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Manager : Angajat
    {
        public string Departament { get; set; }
    
        public Manager(string nume,string departament):base(nume)
        {
            Departament = departament;
        }

        public override void AfisareDetalii()
        {
            Console.WriteLine("Numele managerului: {0}", Nume);
            Console.WriteLine("Departamenul: {0}", Departament);
        }

    }
}
