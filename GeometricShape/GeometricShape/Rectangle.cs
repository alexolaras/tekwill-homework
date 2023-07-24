using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double length, double height) : base(name)
        {
            Name = name;
            Length = length;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Length * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Length + 2 * Height;
        }
    }
}
