namespace Volleyball
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int weekendsInHome = int.Parse(Console.ReadLine());

            const int weekendsPerYear = 48;
            
            double weekendInSofia = weekendsPerYear - weekendsInHome;
            double playInSofia = weekendInSofia * 3.0 / 4.0;
            double playInHollydays = holydays * 2.0 / 3.0;
            double playInHome = weekendsInHome;

            double play = playInSofia + playInHome + playInHollydays;

            if (year == "leap")
            {
                play *= 1.15;
                Console.WriteLine(Math.Floor(play));
            }
            else
            {
                Console.WriteLine(Math.Floor(play));
            }
        }
    }
}
