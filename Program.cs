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
            Random r = new Random();

            int mysNum = r.Next(1, 101);
            Console.WriteLine(mysNum);
            bool run = true;
            int guesses = 0; 

            while (run == true)
            {
                guesses++;
                Console.WriteLine("Please input a guess");
                int input = int.Parse(Console.ReadLine());
                int diff = 0;
                if (input == mysNum)
                {
                    Console.WriteLine("Match! You win!");
                    break;
                }
                else if (input > mysNum)
                {
                    diff = input - mysNum;
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
                    diff = mysNum - input;
                    if (diff > 10)
                    {
                        Console.WriteLine("Way too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too low");
                    }
                }

            }

            Console.WriteLine("You guessed " + guesses + " times");
            if(guesses < 5)
            {
                Console.WriteLine("Wow you're a genius");
            }
            else if(guesses < 10)
            {
                Console.WriteLine("Pretty solid!");
            }
            else if(guesses < 20)
            {
                Console.WriteLine("Better luck next time, ya dangus");
            }

        }
    }
}
