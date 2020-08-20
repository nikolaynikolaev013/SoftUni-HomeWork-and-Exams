using System;

namespace Concat_names
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            Console.WriteLine($"{str1}{str3}{str2}");
        }
    }
}
