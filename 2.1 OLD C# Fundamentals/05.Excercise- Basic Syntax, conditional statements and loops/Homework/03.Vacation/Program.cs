using System;

namespace Vacation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int howMuchPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfVisit = Console.ReadLine();
            double price = 0;
            double total = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfVisit == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfVisit == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfVisit == "Sunday")
                    {
                        price = 10.46;
                    }

                    if (howMuchPeople >= 30)
                    {
                        total = (price * howMuchPeople) * 0.85;
                    }
                    else
                    {
                        total = price * howMuchPeople;
                    }
                    break;

                case "Business":
                    if (dayOfVisit == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfVisit == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfVisit == "Sunday")
                    {
                        price = 16;
                    }

                    if (howMuchPeople >= 100)
                    {
                        total = price * (howMuchPeople - 10);
                    }
                    else
                    {
                        total = price * howMuchPeople;
                    }
                    break;

                case "Regular":
                    if (dayOfVisit == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfVisit == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfVisit == "Sunday")
                    {
                        price = 20.50;
                    }

                    if (howMuchPeople >= 10 && howMuchPeople <= 20)
                    {
                        total = (price * howMuchPeople) * 0.95;
                    }
                    else
                    {
                        total = price * howMuchPeople;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {total:F2}");
            
        }
    }
}
