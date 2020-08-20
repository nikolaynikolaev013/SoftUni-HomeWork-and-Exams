using System;

namespace Lower_or_upper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            
            if (ch1.ToString().ToLower() == ch1.ToString())
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
