using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    internal class Pyramid
    {
        public static void PrintPyramid(int x)
        {
            string s = "*";
            int totalStar = 2 * x;
            for (int i = 0; i <= x; i++) 
            {
                string tmp = "";
                for (int j = 0; j < totalStar; j++)
                {
                    if (j < x-i | j >= x + i - 1)
                    { 
                        tmp += " ";
                    }
                    else { tmp += s; }
                }
                Console.WriteLine(tmp);
            
            }
            
        }
    }
}
