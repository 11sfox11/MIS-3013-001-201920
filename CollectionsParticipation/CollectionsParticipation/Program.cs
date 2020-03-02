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
            Console.ReadKey();
        }
    }
}
