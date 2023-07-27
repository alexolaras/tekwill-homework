using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Contabil : Angajat
    {
        public Contabil(string nume, DateTime dataAngajarii) : base(nume, dataAngajarii)
        {

        }

        public override double CalculeazaSalariu()
        {
            var salariu = base.CalculeazaSalariu();
            var exparienta = (int)(DateTime.Now - DataAngajarii).TotalDays / 365;

            return salariu + salariu * 0.2 * exparienta;
        }
    }
}
