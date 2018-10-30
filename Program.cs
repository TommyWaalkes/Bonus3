using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool foundNum = false;
            
            GuessingGameApp ga = new GuessingGameApp();
            Guesser brute = new BruteForce();

            Console.WriteLine();
            while (foundNum == false)
            {
                int guess = brute.Guess();
                foundNum = ga.GuessAnswer(guess);
            }

            brute.PrintGuesses();

        }
    }
}
