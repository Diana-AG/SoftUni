namespace _01.ReadText2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
