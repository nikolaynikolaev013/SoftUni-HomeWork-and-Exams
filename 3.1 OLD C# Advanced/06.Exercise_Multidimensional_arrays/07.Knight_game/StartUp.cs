using System;

namespace _07.Knight_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (board[row, col] == 'K')
                    {
                        counter = AttackCheck(n, board, counter, row, col, 1, 2);
                        counter = AttackCheck(n, board, counter, row, col, -1, 2);
                        counter = AttackCheck(n, board, counter, row, col, 2, 1);
                        counter = AttackCheck(n, board, counter, row, col, 2, -1);
                        counter = AttackCheck(n, board, counter, row, col, -1, -2);
                        counter = AttackCheck(n, board, counter, row, col, 1, -2);
                        counter = AttackCheck(n, board, counter, row, col, -2, -1);
                        counter = AttackCheck(n, board, counter, row, col, -2, 1);
                    }

                }
            }

            Console.WriteLine(counter);

        }

        private static int AttackCheck(int n, char[,] board, int counter, int row, int col, int moveRow, int moveCol)
        {
            if (col + moveCol < n
                && col + moveCol >= 0)
            {
                if (row + moveRow < n
                    && row + moveRow >= 0)
                {
                    if (board[row + moveRow, col + moveCol] == 'K')
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
