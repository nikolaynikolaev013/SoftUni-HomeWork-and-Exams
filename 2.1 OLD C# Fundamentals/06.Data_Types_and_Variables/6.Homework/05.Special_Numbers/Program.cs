using System;

namespace Special_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int temp = 0;

            for (int i = 1; i <= n; i++)
            {
                temp = i;
                totalSum = 0;


                while (temp != 0)
                {
                    totalSum += temp % 10;
                    temp /= 10;
                }

                if (totalSum == 5 || totalSum == 7 || totalSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
