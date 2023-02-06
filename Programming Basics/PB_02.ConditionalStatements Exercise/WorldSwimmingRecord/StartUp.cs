namespace WorldSwimmingRecord
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecForOneMeter = double.Parse(Console.ReadLine());

            double score = distanceInMeters * timeInSecForOneMeter;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalScore = score + delay;

            double result = Math.Abs(record - totalScore);
            if (record > totalScore)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalScore:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {result:f2} seconds slower.");
            }
        }
    }
}
