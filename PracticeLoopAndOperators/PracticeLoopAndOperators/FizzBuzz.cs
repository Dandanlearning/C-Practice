using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    internal class FizzBuzz
    {
        public static void CheckNum(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(n.ToString());
            }
            return;
        }
    }
}
