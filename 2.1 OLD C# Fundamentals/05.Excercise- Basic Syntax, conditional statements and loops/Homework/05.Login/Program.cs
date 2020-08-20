using System;

namespace Login
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = PassGenerator(user);

            string input = Console.ReadLine();
            int counter = 1;

            while (input != pass)
            {
                if (counter >= 3)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
            }

            if (input == pass)
            {
                Console.WriteLine($"User {user} logged in.");
            }

        }

        public static string PassGenerator(string user)
        {
            string temp="";

            for (int i = user.Length-1; i >= 0; i--)
            {
                temp += user[i];
            }
            return temp;
        }
    }
}
