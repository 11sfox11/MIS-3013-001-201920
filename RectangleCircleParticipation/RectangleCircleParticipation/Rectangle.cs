using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCircleParticipation
{
    class Rectangle
    {

        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Width = 0;
            Length = 0;
        }

        public double CalculateArea()
        {
            double A = Width * Length;
            return A;
        }

        public double CalculatePerimeter()
        {
            double P = 2*(Length + Width);
            return P;
        }
    }
}
