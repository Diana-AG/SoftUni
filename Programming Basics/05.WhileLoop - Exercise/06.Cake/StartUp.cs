namespace _06.Cake
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int cake = a * b;            

            while (command != "STOP")
            {
                int numberOfPieces = int.Parse(command);
                cake -= numberOfPieces;
                if (cake < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }            
            if (cake >= 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
