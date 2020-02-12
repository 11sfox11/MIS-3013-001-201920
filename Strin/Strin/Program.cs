using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Stephanie";
            string lastName = "Fox";

            Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your first name.");
            Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your last name.");

            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            firstName = firstName.ToUpper();

            for (int i = 0; i < firstName.Length ; i++)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            }
            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i = i + 2)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter + " ");
            }
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}.");

            string name = firstName + " "+ lastName;
            for (int i = name.Length - 1; i >=0; i--)
            {
                Console.Write(name[i]);
            }
           
            Console.ReadKey();
        }
    }
}
