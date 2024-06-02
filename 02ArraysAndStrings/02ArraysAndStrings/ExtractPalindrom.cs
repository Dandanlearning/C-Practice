using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class ExtractPalindrom
    {
        public static void PrintPalindrom(string s)
        {
            String[] sb = s.Split(new[] {' ', ',', '?', '!', ':', '.'});
            List<string> list = new List<string>();
            Console.WriteLine(String.Join("|", sb));
            foreach (string s2 in sb)
            {
                if (IsPalindrom(s2) && !String.IsNullOrEmpty(s2)) { list.Add(s2); }
            }
            Console.WriteLine( String.Join(", ", list));
        }
        public static bool IsPalindrom(string s) 
        {
            int left = 0, right = s.Length-1;
            while (left <= right) { 
                if (s[left] != s[right]) { return false; } 
                left++;
                right--;
            }
            return true;
        }

    }
}
