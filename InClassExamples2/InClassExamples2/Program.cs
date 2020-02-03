using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExamples2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables!!
            string toss;
            int numberOfGuesses = 0;
            // ask user to pick heads or tails
            Console.WriteLine("Heads or tails?");
            toss = Console.ReadLine().ToLower();
            //random generator
            Random rnd = new Random();
            string[] headstails = { "heads", "tails" };

            int htIndex = rnd.Next(headstails.Length);
            // display

            Console.WriteLine("I got {0}", headstails[htIndex]);

            while (toss != headstails[htIndex])
            {

                if (toss != headstails[htIndex])
                {
                    Console.WriteLine("Heads or tails?");
                    toss = Console.ReadLine().ToLower();
                    //random generator
                     rnd = new Random();
                     htIndex = rnd.Next(headstails.Length);
                    // display

                    Console.WriteLine("I got {0}", headstails[htIndex]);
                }
                else
                {
                    Console.WriteLine("You Win");

                }
                numberOfGuesses = numberOfGuesses + 1;
            }
           
            Console.WriteLine($"It took you {numberOfGuesses.ToString("N0")} to guess right");
            const string developer = "Stephanie Fox";
            Console.WriteLine(developer);
            Console.ReadKey();

        }
    }
    }

