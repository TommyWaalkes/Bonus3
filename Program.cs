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
            
            GuessingGameApp ga = new GuessingGameApp(10);
            int i = 1;
            while (foundNum == false)
            {
                foundNum = ga.GuessAnswer(i);
                i++;
            }

            

        }
    }
}
