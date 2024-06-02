using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class LongestSequence
    {
        public static List<int> Sequence(int[] nums)
        {
            int left = 0,  right = 0;
            int window = int.MinValue;
            List<int> res = new List<int>();
            while (right < nums.Length)
            {
                while (right < nums.Length && nums[left] == nums[right])
                {
                    right++;
                }
                if ((right - left) > window)
                {
                    window = right - left;
                    res = nums[left..right].ToList();
                    
                }
                left = right;
            }  
            return res;

                

        }
    }
}
