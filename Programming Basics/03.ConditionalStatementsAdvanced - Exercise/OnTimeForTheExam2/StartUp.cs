namespace OnTimeForTheExam2
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int hourOfTheExam = int.Parse(Console.ReadLine());
            int minuteOfTheExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int timeArrival = hourOfArrival * 60 + minuteOfArrival;
            int timeExam = hourOfTheExam * 60 + minuteOfTheExam;

            int diff = timeExam - timeArrival;

            int hh = Math.Abs(diff / 60);
            int mm = Math.Abs(diff % 60);

            if (diff > 30)
            {
                Console.WriteLine("Early");
                if (diff < 60)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hh}:{mm:d2} hours before the start");
                }
            }
            else if (diff < 0)
            {
                Console.WriteLine("Late");
                if (diff > -60)
                {
                    Console.WriteLine($"{Math.Abs(diff)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hh}:{mm:d2} hours after the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (diff != 0)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }         
        }
    }
}
