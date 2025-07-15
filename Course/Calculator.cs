using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Calculator
    {
        public double PI = 3.14;

        public double Circumference(double radius)
        {
            return 2 * PI * radius;
        }

        public double Volume(double radius)
        {
            return (4.0 / 3.0) * PI * Math.Pow(radius, 3);
        }
    }
}
