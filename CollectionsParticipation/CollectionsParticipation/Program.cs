using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //array
            int[] courseNumbers = new int[3];
            string[] subjects = new string[3];

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("Please enter your course subject.");
                string course = Console.ReadLine();
                subjects[i] = course;

                Console.WriteLine("Please enter your class number.");
                int number = Convert.ToInt32(Console.ReadLine());
                courseNumbers[i] = number;
            }


            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"You are enrolled in {subjects[i]} {courseNumbers[i]}.");
            }

            // exam calculator

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
