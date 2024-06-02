using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class UserOperation
    {
        public List<string> items = new List<string>();
        public void Operation(String s)
        {
            if (s[0] == '+')
            {
                String item = "";
                for (int i = 1; i < s.Length; i++)
                {
                    item += s[i];
                }
                //Console.WriteLine("+operationo here");
                items.Add(item);
                //Console.WriteLine(String.Join("", items));

            }
            else
            {
                if (s[0] == s[1])
                {
                    items = new List<string>();
                }
                else
                {   
                    int n = s.Length;
                    string deleteItem = s.Substring(1, n-1);
                    for (int i = 0; i < items.LongCount(); i++)
                    {
                        if (items[i] == deleteItem)
                        {
                            items.RemoveAt(i);
                            i--; // Adjust the index after removal
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(",", items));
            Console.WriteLine("Operation Done");
        }

    }
}
