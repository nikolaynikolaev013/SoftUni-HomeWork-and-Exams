using System;
using System.Collections;
using System.Linq;

namespace _05.Fashion_boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Stack box = new Stack(input);

            int rackCapacity = int.Parse(Console.ReadLine());

            int numOfClothes = 0;
            int numOfRacks = 0;

            if (box.Count > 0)
            {

                while (box.Count > 0)
                {
                    int currentCloth = (int)box.Peek();

                    numOfClothes += currentCloth;
                    box.Pop();

                    while (numOfClothes >= rackCapacity)
                    {
                        numOfClothes -= rackCapacity;
                        numOfRacks++;
                    }
                }

                if (numOfClothes > 0)
                {
                    numOfRacks++;
                }
            }


            Console.WriteLine(numOfRacks);
        }
    }
}
