using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam grades.");
            string prompt = "What is your next score?";

            List<int> scores = new List<int>();
            double sum = 0;
            string more;
            do
            {
                Console.WriteLine(prompt);
                int inputnum = Convert.ToInt32(Console.ReadLine());
                scores.Add(inputnum);
                Console.WriteLine("Do you have another score? Yes or no?");
                more = Console.ReadLine();
                
            } while (more != "no");

            foreach (int item in scores)
            {
                sum = sum + item;
            }

            double average = sum / scores.Count();
            Console.WriteLine($"Your final exam score is {average.ToString("N3")}");
            Console.ReadKey();
        }
    }
}
