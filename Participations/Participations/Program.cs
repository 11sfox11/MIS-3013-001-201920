//Stephanie Fox
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables!!
            string toss;

            // ask user to pick heads or tails
            Console.WriteLine("Heads or tails?");
                toss = Console.ReadLine().ToLower();
            //random generator
            Random rnd = new Random();
            string[] headstails = { "heads", "tails" };

            int htIndex = rnd.Next(headstails.Length);
            // display

            Console.WriteLine("I got {0}", headstails[htIndex] );

            if (toss == headstails[htIndex])
            {
                Console.WriteLine("Your guess was right!");
            }
            else
            {
                Console.WriteLine("You lose!");

            }

            Console.ReadKey();

        }
    }
}
