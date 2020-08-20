using System;

namespace Refactor_Volume_of_Pyramid
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");
            double height = double.Parse(Console.ReadLine());

            double result = (length + width + height) / 3;
            Console.WriteLine($"Pyramid Volume: {result:f2}");

        }
    }
}
