using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class RotateArray
    {
        public static int[] Rotate(int[] nums, int r)
        {
            int[] res = new int[nums.Length];
            int n = nums.Length;
            for (int i = 1; i <= r; i++)
            {
                int[] newArray = new int[nums.Length];
                for (int j = 0; j < nums.Length; j++)
                {
                    newArray[(j + i) % n] = nums[j];
                }
                //Console.WriteLine("this is Roatated array: " + string.Join(",", newArray));
                for (int k = 0; k < n; k++)
                {
                    res[k] += newArray[k];
                }
                //Console.WriteLine("this is Sum Array: " + string.Join(",",res));
            }
            return res;

        }
    }
}
