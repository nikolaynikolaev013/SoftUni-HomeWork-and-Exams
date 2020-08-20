using System;

namespace Homework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(meters / 1000.0):F2}");
        }
    }
}
