using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string name) : base(name)
        {
            Radius = radius;
            Name = name;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
