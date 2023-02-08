namespace _02.Password
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            
            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
