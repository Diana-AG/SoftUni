namespace _09.Moving
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int volume = a * b * h;

            while (input != "Done")
            {
                int numberOfBoxes = int.Parse(input);
                volume -= numberOfBoxes;
                if (volume < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (volume < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
        }
    }
}
