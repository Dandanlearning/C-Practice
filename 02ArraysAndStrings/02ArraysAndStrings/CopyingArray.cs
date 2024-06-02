using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class CopyingArray
    {

        public static Object[] Copying(Object[] num)
        {
            var copied = new object[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                copied[i] = num[i];
                Console.WriteLine($"this is original array , {i} item is " + num[i]);
                Console.WriteLine($"this is copied array {i} item is " + copied[i]);
            }
            return copied;
        }
    }
}
