using System;

namespace Refactor_Special_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int temp = 0;
            bool check = false;

            for (int i = 1; i <= n; i++)
            {
                temp = i;

                while (i > 0)
                {
                    totalSum += i % 10;
                    i = i / 10;
                }

                check = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine("{0} -> {1}", temp, check);
                totalSum = 0;
                i = temp;
            }

        }
    }
}
