using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopAndOperators
{
    public class CountAge
    {
        public static void Count(string x)
        {
            DateOnly birth = DateOnly.ParseExact(x, "MM-dd-yyyy", CultureInfo.InvariantCulture);
            DateOnly now = new DateOnly(2024, 05, 28);
            TimeSpan diff = now.ToDateTime(TimeOnly.MinValue) - birth.ToDateTime(TimeOnly.MinValue);
            Console.WriteLine($"You are {diff.Days} days old");
            int daysToNextAn = 10000 - diff.Days % 10000;
            Console.WriteLine($"Your next 10000 Anniversary is {now.AddDays(daysToNextAn)}");
            return;
        }
    }
}
