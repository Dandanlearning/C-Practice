using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    internal class GuessNum
    {
        public static void Guess() {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("What is yourguess?");
            int x = Int32.Parse(Console.ReadLine());
            while (x!= correctNumber)
            {
                if (x > correctNumber)
                {
                    if (x > 3) { Console.WriteLine("You guess higher over the range"); }
                    else { Console.WriteLine("You guess high"); }
                    Console.WriteLine("What is yourguess?");
                    x = Int32.Parse(Console.ReadLine()); 
                }
                else if (x < correctNumber) 
                {
                    if (x < 1) { Console.WriteLine("You guess lower than the range"); }
                    else { Console.WriteLine("You guess low"); }
                    Console.WriteLine("What is yourguess?");
                    x = Int32.Parse(Console.ReadLine());
                }
            }
           
            Console.WriteLine("Bingo!");
            return;
            
        }
    }
}
