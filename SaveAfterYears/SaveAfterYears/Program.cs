using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAfterYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money will you save per week?");
            double saved = Convert.ToDouble(Console.ReadLine());
            double newSaved = 0;

            Console.WriteLine("What is your interest rate?");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years will you save for?");
            double years = Convert.ToDouble(Console.ReadLine());
           

            double totalWeeks = 4 * 12 * years;

            double months = years * 12;

            for (int i = 0; i <= months; i++)
            {

                newSaved = saved + (saved * (rate + 1));
                Console.WriteLine("You have saved " + saved + " in " + i + " months");
            
            }

            Console.ReadKey();
        }
    }
}
