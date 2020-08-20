using System;

namespace Exact_sum_to_real_numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0M;
            decimal temp = 0M;

            for (int i = 0; i < n; i++)
            {
                temp = decimal.Parse(Console.ReadLine());

                total += temp;
            }

            Console.WriteLine(total);
        }
    }
}
