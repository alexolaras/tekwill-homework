using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Programator : Angajat
    {
        public List<string> Limbaje { get; set; }

        public Programator(string name, DateTime dataAngajarii, List<string> limbaje) : base(name, dataAngajarii) 
        {
            Limbaje = limbaje;
        }

        public void AdaugaLimbaj(string limbaj)
        {
            Limbaje.Add(limbaj);
        }

        public override double CalculeazaSalariu()
        {
            var salariuMinim = base.CalculeazaSalariu();
            double salariuFinal = salariuMinim;

            foreach (string limbaj in Limbaje)
            {
                if(limbaj.ToLower() == "c#")
                {
                    salariuFinal += salariuMinim * 4;
                }
                else
                {
                    salariuFinal += salariuMinim * 0.5;
                }
            }
            return salariuFinal;
        }
    }
}
