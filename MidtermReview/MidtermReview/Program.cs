using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInTheMonth

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the name of a month.");
            string userMonth = Console.ReadLine().ToLower();
            int days = 0;

            if (userMonth == "february")
            {
                Console.WriteLine("Is it a leap year?");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    days = 29;
                }
                else
                    days = 28;
            }
            
            if (userMonth == "january")
            {
                days = 31;
            }

            if (userMonth == "march")
            {
                days = 31;
            }

            if (userMonth == "april")
            {
                days = 30;
            }

            if (userMonth == "may")
            {
                days = 31;
            }

            if (userMonth == "june")
            {
                days = 30;
            }

            if (userMonth == "july")
            {
                days = 31;
            }

            if (userMonth == "august")
            {
                days = 31;
            }
            if (userMonth == "september")
            {
                days = 30;
            }
            if (userMonth == "october")
            {
                days = 31;
            }
            if (userMonth == "november")
            {
                days = 30;
            }
            if (userMonth == "december")
            {
                days = 31;
            }
            
            Console.WriteLine( userMonth + " has " + days + " days in it.");
            Console.ReadKey();
        }
    }
}
