﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Which participations do you want to run? ExamScore, WordReplace, CoinToss, all" );
            string answer = Console.ReadLine();
            if (answer == "ExamScore")
            {
                examScore();
            }
            if (answer == "WordReplace" )
            {
                wordReplace();
            }

            if (answer == "CoinToss")
            {
                coinToss();
            }

            if (answer == "all")
            {
                all();
            }
            Console.ReadKey();
        }

        static void coinToss()
        {
            string toss;
            
            Console.WriteLine("Heads or tails?");
            toss = Console.ReadLine().ToLower();
            Random rnd = new Random();
            string[] headstails = { "heads", "tails" };

            int htIndex = rnd.Next(headstails.Length);

            Console.WriteLine("I got {0}", headstails[htIndex]);

            if (toss == headstails[htIndex])
            {
                Console.WriteLine("Your guess was right!");
            }
            else
            {
                Console.WriteLine("You lose!");

            }


        }
        
        static void wordReplace()
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
        }
        static void examScore()
        {
            Console.WriteLine("Please enter your exam grades. Type 'done' when you are done.");
            string prompt = "What is your next score?";

            List<int> scores = new List<int>();
            double sum = 0;
            string more;
            do
            {
                Console.WriteLine(prompt);
                int inputnum = Convert.ToInt32(Console.ReadLine());
                scores.Add(inputnum);
                Console.WriteLine("Type 'yes' if you have another score.");
                more = Console.ReadLine();
                sum += inputnum;
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
            double avg = sum / scores.Count;
            Console.WriteLine("Your max exam score is " + max);
            Console.WriteLine("Your minimum exam score is " + min);
            Console.WriteLine("Your average score is " + avg);
        }
        static void all()
        {
            examScore();
            coinToss();
            wordReplace();

        }

    }
}
