using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace participaton2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(phrase);
            Console.WriteLine("What word do you want to replace above?");
            string oldWord = Console.ReadLine();
            Console.WriteLine("What do you want to replace it with?");
            string newWord = Console.ReadLine();

            bool b = phrase.Contains(oldWord);

            if (b == true)
            {
                Console.WriteLine(phrase.Replace(oldWord, newWord));
            }
            else
            {
                Console.WriteLine("I could not find the word " + oldWord + ".");

                for (int i = oldWord.Length - 1; i >= 0; i--)
                {

                    Console.Write(oldWord[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
