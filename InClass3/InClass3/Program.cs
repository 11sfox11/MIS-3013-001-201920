using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] studentIds = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" };

            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            
            for (int i = 0; i < studentIds.Length; i++)
            {
                Console.WriteLine($"Student with ID {studentIds[i]} has a name of {studentNames[i]}");

            }
            //list
            List<int> studIds = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>();
            studNames.Add("Lakin");
            studNames.Add("Grant");
            studNames.Add("Eric");

            for (int i = 0; i < studIds.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIds[i]} has a name of {studNames[i]}");

            }

            //dictionary

            Dictionary<int, string> students = new Dictionary<int, string>();

            for (int i = 0; i < studentIds.Length; i++)
            {
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studentIds[i], studentNames[i]);
                }
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studIds[i], studNames[i]);
                }
            }
            Console.WriteLine("made it through!");

            Console.WriteLine($"The dictionary has {students.Count()} students");
            Console.ReadKey();
        }
    }
}
