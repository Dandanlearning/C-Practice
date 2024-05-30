using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    internal class Increment
    {
        public static void IncrementPrint()
        {
            for (int i = 1; i <= 4; i ++)
            {
                //int[] res = new int[0];
                for (int j = 0; j <= 24; j += i)
                {
                    Console.Write(" "+ j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
