using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Papagal : Pasare
    {
        public string Vocabular { get; set; }

        public override void AfisareDetalii()
        {
            Console.WriteLine("Nume papagal: {0}", Nume);
            Console.WriteLine("Tipul zborului: {0}", TipZbor);
            Console.WriteLine("Vocabular: {0}", Vocabular);
        }
    }
}
