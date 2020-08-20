using System;

namespace Pounds_to_dollars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{(pounds * 1.31M):F3}");
        }
    }
}
