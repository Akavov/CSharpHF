using System;

namespace ConsoleApp17
{
    class Program
    {
        delegate string ConvertsIntToString(int i);
        static void Main(string[] args)
        {
            ConvertsIntToString someMethod = new ConvertsIntToString(HiThere);
            string message = someMethod(5);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        private static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }
    }
}
