using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class ReverseString
    {
        public static string Reverse(string s) 
        { 
            StringBuilder sb = new StringBuilder(s);
            int left = 0, right = sb.Length-1;
            while (left <= right) {
                char tmp = sb[left];
                sb[left] = sb[right];
                sb[right] = tmp;
                left++;
                right--;
            }
            return sb.ToString();
        }
    }
}
