using System;

namespace Centures_to_minutes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            double days = years * 365.2422;
            long hours = (long)days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");

        }
    }
}
