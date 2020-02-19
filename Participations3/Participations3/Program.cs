using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam grades. Type 'done' when you are done.");
            string prompt = "What is your next score?";
            
            List<int> scores = new List<int>();

            string more;
            do
            {
                Console.WriteLine(prompt);
                int inputnum = Convert.ToInt32(Console.ReadLine());
                scores.Add(inputnum);
                Console.WriteLine("Type 'yes' if you have another score.");
                more = Console.ReadLine();
            } while (more == "yes");
            int max = -78909;
            int min = 40000;
            for (int i = 0; i < scores.Count; i++)
            {
               
                if (scores[i] > max)
                {
                    max = scores[i]; 
                }
                if (scores[i] < min)
                {
                    min = scores[i];
                }

                     
            }

            Console.WriteLine("Your max exam score is " + max);
            Console.WriteLine("Your minimum exam score is " + min);

            Console.ReadKey();
        }
    }
}
