using System;

namespace Vending_Machine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double temp = 0;
            double totalMoney = 0;

            string command = Console.ReadLine();

            bool notEnough = false;

            do
            {
                temp = double.Parse(command);
                if (temp == 0.1 || temp == 0.2 || temp == 0.5 || temp == 1 || temp == 2)
                {
                    totalMoney += temp;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {temp}");
                }

                command = Console.ReadLine();

            } while (command != "Start");

            command = Console.ReadLine();

            do
            {
                notEnough = false;
                switch (command)
                {   
                    case "Nuts":
                        if (2 <= totalMoney)
                        {
                            totalMoney -= 2;
                        }
                        else
                        {
                            notEnough = true; ;
                        }
                        break;
                    case "Water":
                        if (0.7 <= totalMoney)
                        {
                            totalMoney -= 0.7;
                        }
                        else
                        {
                            notEnough = true; ;
                        }
                        break;
                    case "Crisps":
                        if (1.5 <= totalMoney)
                        {
                            totalMoney -= 1.5;
                        }
                        else
                        {
                            notEnough = true; ;
                        }
                        break;
                    case "Soda":
                        if (0.8 <= totalMoney)
                        {
                            totalMoney -= 0.8;
                        }
                        else
                        {
                            notEnough = true; ;
                        }
                        break;
                    case "Coke":
                        if (1 <= totalMoney)
                        {
                            totalMoney -= 1;
                        }
                        else
                        {
                            notEnough = true; ;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (notEnough)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {command}");
                }

                command = Console.ReadLine();
            } while (command != "End");

            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
