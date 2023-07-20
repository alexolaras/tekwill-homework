using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal class Mamifer : Animal
    {
        public string CuloareBlana { get; set; }

        public override void AfisareDetalii()
        {
            Console.WriteLine("Numele mamiferului: {0}", Nume);
            Console.WriteLine("Culoarea blanii: {0}", CuloareBlana);
        }
    }
}
