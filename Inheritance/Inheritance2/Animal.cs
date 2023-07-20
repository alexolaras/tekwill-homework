using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Animal
    {
        public string Nume { get; set; }

        public virtual void AfisareDetalii()
        {
            Console.WriteLine("Numele animalului: {0}", Nume);
        }
    }
}
