using System;

namespace Padawan_Equipment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double howMuchMoney = double.Parse(Console.ReadLine());
            int howManyStudents = int.Parse(Console.ReadLine());
            double priceForLightSaber = double.Parse(Console.ReadLine());
            double priceForRobes = double.Parse(Console.ReadLine());
            double priceForBelts = double.Parse(Console.ReadLine());

            double totalPriceLightSabers = (Math.Ceiling(howManyStudents * 1.10)) * priceForLightSaber;
            double totalPriceForBelts = (howManyStudents - howManyStudents / 6) * priceForBelts;
            double totalPrice = totalPriceForBelts + totalPriceLightSabers + howManyStudents * priceForRobes;

            if (totalPrice <= howMuchMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else if (totalPrice > howMuchMoney)
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-howMuchMoney:F2}lv more.");
            }
        }
    }
}
