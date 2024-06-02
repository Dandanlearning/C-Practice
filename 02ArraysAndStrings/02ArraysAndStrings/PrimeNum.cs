using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class PrimeNum
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum <= 2) startNum = 2;
            bool[] isPrime = new bool[endNum + 1];
            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }
            for (int p = 2; p <= endNum; p++)
            {
                    for (int i = p; i * p <= endNum; i++)
                    {
                        isPrime[i*p] = false;
                    }
                
            }
            for (int i = startNum; i <= endNum; i++)
            {
                if (isPrime[i]) primes.Add(i); 
            }
            //foreach (int num in primes)
            //{
            //    Console.WriteLine(num);
            //}
            return primes.ToArray();
        }
    }
}
