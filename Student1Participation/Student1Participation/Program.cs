// I was pretty confused by this participation, and I think a video like the one originally posted for classes would've really helped me figure out what to do with the lists inside the classes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            Student Student1 = new Student();
            Student1.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            Student1.LastName = Console.ReadLine();

            string answer;
            double totalPoints = 0;
            double classes = 0;
            do
            {
                classes += 1;
                Console.WriteLine("What class are you in?");
                Student1.CourseNames.Add(Console.ReadLine());

                Console.WriteLine("What is your letter grade in that class?");
                string grade = Console.ReadLine();
                if (grade == "A")
                {
                    totalPoints += 4.00;
                }
                if (grade == "B")
                {
                    totalPoints += 3.00;
                }
                if (grade == "C")
                {
                    totalPoints += 2.00;
                }
                if (grade == "D")
                {
                    totalPoints += 1.00;
                }
                if (grade == "F")
                {
                    totalPoints += 0;
                }
                Console.WriteLine("Are you enrolled in any other classes? Yes or no?");
                answer = Console.ReadLine();
                
            } while (answer == "yes");

            double GPA = totalPoints / classes;
            Console.WriteLine("Hi" + Student1 + "Your GPA is " + GPA + "." );


            Console.ReadKey();
        }
    }
}
