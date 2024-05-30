// See https://aka.ms/new-console-template for more information
using System;
namespace PracticeLoopAndOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            RequestType[] requestTypes = (RequestType[])Enum.GetValues(typeof(RequestType));
            Console.WriteLine("What do you want to do?");
            foreach (RequestType requestType in requestTypes)
            {
                Console.WriteLine($"{(int)requestType} represent { requestType.ToString()}");
            }
            RequestType request = (RequestType) Enum.ToObject(typeof(RequestType), Int32.Parse(Console.ReadLine()));
            //Console.WriteLine(request.ToString());

            if (request == RequestType.FizzBuzzGame)
            {
                Console.WriteLine("What number you want to try for FizzBuzz Game?");
                int n = Int32.Parse(Console.ReadLine());
                FizzBuzz.CheckNum(n);
            }
            else if (request == RequestType.PrintPyramidGame)
            {
                Console.WriteLine("What number you want to try for PrintPyramid Game?");
                int n = Int32.Parse(Console.ReadLine());
                Pyramid.PrintPyramid(n);
            }
            else if (request == RequestType.GuessNumberGame)
            {
                Console.WriteLine("Game Start");
                GuessNum.Guess();
            }
            else if (request == RequestType.AgeInDayGame)
            {
                Console.WriteLine("What is your birth day? Please enter in mm-dd-yyyy format");
                string birthday = Console.ReadLine();
                CountAge.Count(birthday);
            }
            else if (request == RequestType.GreetingGame)
            {
                Greet.Greeting();
            }
            else // for request that to see increment game.
            {
                Increment.IncrementPrint();
            }
        }
    }
}