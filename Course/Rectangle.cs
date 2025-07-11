using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Rectangle
    {
        public double Width; 
        public double Heigth;

        public double Area()
        {
            return Width * Heigth;
        }

        public double Perimeter()
        {
            return (2 * Width) + (2 * Heigth);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Heigth, 2));
        }
    }
}
