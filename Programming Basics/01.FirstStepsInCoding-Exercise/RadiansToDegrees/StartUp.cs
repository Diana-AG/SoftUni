namespace RadiansToDegrees
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
