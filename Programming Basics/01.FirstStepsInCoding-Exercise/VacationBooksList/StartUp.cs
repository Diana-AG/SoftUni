namespace VacationBooksList
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine(numberOfPages / pagesPerHour / numberOfDays);
        }
    }
}