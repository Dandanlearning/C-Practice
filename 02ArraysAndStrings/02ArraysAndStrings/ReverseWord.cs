using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class ReverseWord
    {
        public static void Reverse(string s)
        {
            HashSet<string> memo = new HashSet<string> { " ", ",", "(", ")", "[", "]",";", "=",".","/", "!", "?", "\'", "\"", "\\"};
            //string[] sb = s.Split(new [] { " ", ",", "(", ")", "[", "]", ";", "=", ".", "/", "!", "?", "\'", "\"", "\\" });
            //Console.WriteLine(String.Join("|" , sb)+ "Here is only words");
            string[] sb1 = Regex.Split(s, @"([.,:;=\()&[\]""'/!? ])");
            List<string> list = new List<string>();
            for (int i = 0; i < sb1.Length; i++)
            {
                if (!string.IsNullOrEmpty(sb1[i])) list.Add(sb1[i]);
            }
            string[] sb  = list.ToArray();
            int left = 0, right = sb.Length - 1;
            while (left <= right)
            {
                while (right > left && memo.Contains(sb[left]) | sb[left] is null) 
                {
                    left++;
                }
                while (right > left && memo.Contains(sb[right]) | sb[right] is null) right--;
                if (left <= right)
                {
                    string tmp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = tmp;
                }
                left++;
                right--;
            }
            Console.WriteLine(String.Join("", sb));



        }
    }
}
