using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;

namespace _02ArraysAndStrings
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var num = new object [] { 1, 2, "3", "good", "Danna" };
            var newList = CopyingArray.Copying(num);
            Console.WriteLine(String.Join(" ", num));
            Console.WriteLine("This is copied list: "+String.Join(" ", num));
            UserOperation client = new UserOperation();
            Console.WriteLine("For Operation Game");
            Console.WriteLine("Enter command (+item, -item, or -- to clear)):");
            for (int i = 0; i <= 5; i++) 
            {
                String operate = Console.ReadLine();
                client.Operation(operate);
            }
            Console.WriteLine("Now for PrimeNum Game");
            Console.WriteLine("What is your Start Number?");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End Number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Join(",", PrimeNum.FindPrimesInRange(start, end)));
            

            /*******************************************************/
            int[] nums = { 3, 2, 4, -1 };
            int r = 2;
            Console.WriteLine("This is for rotate Function.");
            Console.WriteLine("input : nums[3, 2, 4, -1], rotate time = 2 ");
            Console.WriteLine(String.Join(",", RotateArray.Rotate(nums, r)));

            /*******************************************************/
            Console.WriteLine("This is for LongestSequence Function.");
            Console.WriteLine("input : nums[2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
            int[] nums2 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            Console.WriteLine(String.Join(",", LongestSequence.Sequence(nums2)));

            /*******************************************************/
            Console.WriteLine("This is Reserve Sting");
            Console.WriteLine("what is your string? ");
            string s = Console.ReadLine();
            Console.WriteLine(ReverseString.Reverse(s));

            /*******************************************************/
            Console.WriteLine("What sentence you want to reverse? ");
            string sentence = Console.ReadLine();
            ReverseWord.Reverse(sentence);
            /*******************************************************/
            ExtractPalindrom.PrintPalindrom("Hi,exe? ABBA! Hog fully a string: ExE. Bob");


            /*******************************************************/
            Console.WriteLine( "What is your URL? ");
            string url = Console.ReadLine();
            Url.Parse(url);
        }
    }
}
