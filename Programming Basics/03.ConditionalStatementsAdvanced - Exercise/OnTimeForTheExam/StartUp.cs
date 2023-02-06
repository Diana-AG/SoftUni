namespace OnTimeForTheExam
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

            int allInMinutesArrival = hourOfArrival * 60 + minuteOfArrival;
            int allInMinutesExam = hourOfTheExam * 60 + minuteOfTheExam;

            int inconformity = allInMinutesExam - allInMinutesArrival;
            
            if (inconformity == 0)
            {
                Console.WriteLine("On time");
            }
            else if (inconformity > 0 && inconformity <= 30)
            {
                int mm = inconformity;
                Console.WriteLine("On time");
                Console.WriteLine($"{mm} minutes before the start");
            }
            else if (inconformity > 30 && inconformity < 60)
            {
                int mm = inconformity;
                Console.WriteLine("Early");
                Console.WriteLine($"{mm} minutes before the start");
            }
            else if (inconformity >= 60)
            {
                int hh = inconformity / 60;
                int mm = inconformity % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hh}:{mm:d2} hours before the start");
            }
            else if (inconformity < 0 && inconformity > -60)
            {
                int mm = Math.Abs(inconformity);
                Console.WriteLine("Late");
                Console.WriteLine($"{mm} minutes after the start");
            }
            else
            {
                int hh = Math.Abs(inconformity / 60);
                int mm = Math.Abs(inconformity % 60);
                Console.WriteLine("Late");
                Console.WriteLine($"{hh}:{mm:d2} hours after the start");
            }
        }
    }
}
