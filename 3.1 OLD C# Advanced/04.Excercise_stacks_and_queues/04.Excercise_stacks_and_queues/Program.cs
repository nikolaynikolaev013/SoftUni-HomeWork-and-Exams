using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Excercise_stacks_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var N = command[0];
            var S = command[1];
            var X = command[2];

            var stack = new Stack<int>();

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            for (int i = 0; i < S; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Peek());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
