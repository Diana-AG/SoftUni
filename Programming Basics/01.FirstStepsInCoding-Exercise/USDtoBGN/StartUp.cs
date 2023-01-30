namespace USDtoBGN
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgnForOneUsd = 1.79549;
            double convertedToBGN = usd * bgnForOneUsd;
            Console.WriteLine($"{convertedToBGN:f2}"); 
        }
    }
}
