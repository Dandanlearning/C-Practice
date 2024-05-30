namespace _02UnderstandingTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string format = "{0,-10} | {1,-15} | {2,-37} | {3,-37}";
            Console.WriteLine(string.Format(format, "DataType", "Number of Bytes", "Min Value", "Max Value"));
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(string.Format(format, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(format, "byte", sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(format, "short", sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(format, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(format, "int", sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(format, "uint", sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(format, "long", sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(format, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine(string.Format(format, "float", sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(format, "double", sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(format, "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue));
            
            TimeConvert timeConvert = new();
            //int x = 81474*83648;
            //Console.WriteLine(x);
            //int x = 5;
            //int y = x++;
            Console.WriteLine("What number do you want to convert, starting at centry?");
            int n = int.Parse(Console.ReadLine());
            timeConvert.TimeResult(n);
        }
    }
}
