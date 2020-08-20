using System;

namespace User
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();

            string temp = "";

            while (temp != pass)
            {
                temp = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {name}!");
        }
    }
}
