using System;

namespace Chars_to_string
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{ch1}{ch2}{ch3}");
        }
    }
}
