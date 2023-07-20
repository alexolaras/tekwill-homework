using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Pasare : Animal
    {
        public string TipZbor { get; set; }

        public override void AfisareDetalii()
        {
            Console.WriteLine("Numele pasarii: {0}", Nume);
            Console.WriteLine("Tipul zborului: {0}", TipZbor);
        }
    }
}
