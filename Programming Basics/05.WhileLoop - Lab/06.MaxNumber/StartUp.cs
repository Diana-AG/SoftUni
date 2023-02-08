namespace _06.MaxNumber
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
