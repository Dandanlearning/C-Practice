using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class TimeConvert
    {
        public int year;
        public float day;
        public float hour;
        public float minute;
        public double second;
        public double millisecond;
        public decimal microsecond;
        public decimal nanosecond;

        public void TimeResult(int cen)
        {
            year = 100 * cen;
            day = (365.242f * year);
            if (day % 1 != 0)
            {
                int t = (int)day;
                day = (float)t;
            }
            hour = 24 * day;
            minute = 60 * hour;
            second = (double)minute * 60;
            millisecond = second * 1000;
            microsecond = (decimal)millisecond * 1000;
            nanosecond = microsecond * 1000;
            Console.WriteLine($"{cen} centuries = {year} years  = {day} days = {hour} hours = " +
                $" {minute} minutes = {second} seconds = {millisecond} milliseconds = {microsecond} microseconds =" +
                $" {nanosecond} nanosecond");

        }
    }
}
