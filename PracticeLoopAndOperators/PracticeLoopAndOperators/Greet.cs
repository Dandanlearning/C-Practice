using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    internal class Greet
    {
        public static void Greeting()
        {
            string res = "";
            DateTime cur = DateTime.Now;
            if (5 <= cur.Hour && cur.Hour <= 12) { res = "Morning"; }
            else if (12 < cur.Hour && cur.Hour < 17) { res = "Afternoon"; }
            else if (17 <= cur.Hour && cur.Hour < 21) { res = "Evening"; }
            else
            {
                res = "Night";
            }
            Console.WriteLine($"Good {res}");
        }
    }
}
