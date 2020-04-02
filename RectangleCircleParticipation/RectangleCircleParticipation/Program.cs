using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCircleParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 7;
            double w = 2; 

            Rectangle rect1 = new Rectangle();
            rect1.Width = 6;
            rect1.Length = 4;

            Rectangle rect2 = new Rectangle();
            rect2.Width = w;
            rect2.Length = l;

            Console.WriteLine("The length of rectangle 1 is " + rect1.Length + " and the width of rectangle 1 is " + rect1.Width + ".");
            Console.WriteLine("The length of rectangle 2 is " + rect2.Length + " and the width of rectangle 2 is " + rect2.Width + ".");

            Console.WriteLine(" The area of rectangle 1 is "+ rect1.CalculateArea() + " and the area of rectangle 2 is "+ rect2.CalculateArea()+ " .");
            Console.WriteLine(" The perimeter of rectangle 1 is " + rect1.CalculatePerimeter() + " and the perimeter of rectangle 2 is " + rect2.CalculatePerimeter() + " .");

            double r = 9;

            Circle circle1 = new Circle();
            circle1.Radius = r;

            Circle circle2 = new Circle();
            circle2.Radius = 12;
            Console.WriteLine("The radius of circle 1 is " + circle1.Radius + " and the radius of circle 2 is " + circle2.Radius + ".");
            Console.WriteLine("The area of circle 1 is " + circle1.CalculateArea() + " and the area of circle 2 is " + circle2.CalculateArea() + ".");
            Console.WriteLine("The perimeter of circle 1 is " + circle1.CalculatePerimeter() + " and the perimeter of circle 2 is " + circle2.CalculatePerimeter() + ".");

            Console.ReadKey();
        }
    }
}
