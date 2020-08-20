using System;

namespace Rage_Expenses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            int howManyHeadset = 0;
            int howManyMouse = lostGames;
            int howManyKeyboard = 0;
            int howManyDisplays = 0;

            if (lostGames > 1)
            {
                howManyHeadset = lostGames / 2;
            }

            Console.WriteLine(howManyHeadset);

            if (howManyHeadset > 1)
            {
                howManyMouse = lostGames / 3;
            }
            Console.WriteLine(howManyMouse);

            if (lostGames > 6)
            {
                howManyKeyboard = lostGames / 6;
            }
            Console.WriteLine(howManyKeyboard);

            if (howManyKeyboard > 1)
            {
                howManyDisplays = howManyKeyboard / 2;
            }

            Console.WriteLine(howManyDisplays);
            double totalPrice = howManyHeadset * priceHeadset + howManyMouse * priceMouse + howManyKeyboard * priceKeyboard + howManyDisplays * priceDisplay;

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");

        }
    }
}
