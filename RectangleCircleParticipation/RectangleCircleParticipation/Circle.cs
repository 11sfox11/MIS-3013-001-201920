using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCircleParticipation
{
    class Circle
    {

        public double Radius { get; set; }
        public Circle ()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            double A;
            double pi = Math.PI;
            A = pi*Radius*Radius;
            return A;
        }

        public double CalculatePerimeter()
        {
            double P;
            double pi = Math.PI;
            P = 2 * pi * Radius;
            return P;
        }
    }
}
