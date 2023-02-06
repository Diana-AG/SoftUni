namespace TimePlus15_Minutes
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int hourAfter15min = 0;
            int minAfter15min = 0;
             
            if (minutes <= 44)
            {
                hourAfter15min = hour;
                minAfter15min = minutes + 15;
            }
            else if (minutes > 44 && hour < 23)
            {
                hourAfter15min = hour + 1;
                minAfter15min = (minutes + 15) % 60;
            }
            else if (minutes > 44 && hour >= 23)
            {
                hourAfter15min = hour + 1 - 24;
                minAfter15min = (minutes + 15) % 60;
            }                  
            Console.WriteLine($"{hourAfter15min}:{minAfter15min:d2}");
        }
    }
}
