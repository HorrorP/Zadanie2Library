using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLib
{
    public class Triangle:Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            ValidateTriangle();
        }

        private void ValidateTriangle()
        {
            if (A + B <= C || A + C <= B || B + C <= A)
            {
                throw new ArgumentException("Invalid triangle sides");
            }
        }

        public override double Area()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightAngle()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
        }
    }
}
