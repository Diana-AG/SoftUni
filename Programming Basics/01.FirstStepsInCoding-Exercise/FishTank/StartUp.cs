namespace FishTank
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double aquariumVolumeInSquareSm = a * b * h;
            double aquariumVolumeInSquareDm = aquariumVolumeInSquareSm / 1000;            
            Console.WriteLine(aquariumVolumeInSquareDm * (1 - percentage * 0.01));
        }
    }
}