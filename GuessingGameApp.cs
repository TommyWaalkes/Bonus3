using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class GuessingGameApp
    {
        Random r = new Random();
        private int num;
        private int guessCount = 0;
        public int GuessCount { get { return guessCount; } }
        public GuessingGameApp()
        {
            num = r.Next(1, 101);
            Console.WriteLine(num);
        }

        public GuessingGameApp(int num)
        {
            this.num = num;
        }

        public bool GuessAnswer(int input)
        {
            guessCount++;
            int diff = 0;
            if (input == num)
            {
                Console.WriteLine("Match! You win!");
               
                PrintGuesses();
                return true;
            }
            else if (input > num)
            {
                diff = input - num;
                if (diff > 10)
                {
                    Console.WriteLine("Way too high");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }
            }
            else
            {
                diff = num - input;
                if (diff > 10)
                {
                    Console.WriteLine("Way too low!");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
            }

            return false;
        }

        public void PrintGuesses()
        {
            Console.WriteLine("You guessed " + guessCount + " times");
            if (guessCount < 5)
            {
                Console.WriteLine("Wow you're a genius");
            }
            else if (guessCount < 10)
            {
                Console.WriteLine("Pretty solid!");
            }
            else if (guessCount < 20)
            {
                Console.WriteLine("Better luck next time, ya dangus");
            }
        }


    }
}
