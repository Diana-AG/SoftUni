using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studioPricePerNight = 0.0;
            double apartmentPricePerNight = 0.0;                  

            switch (month)
            {
                case "May":
                case "October":

                    studioPricePerNight = 50;
                    apartmentPricePerNight = 65;


                    if (numberOfNights > 7 && numberOfNights <= 14)
                    {
                        studioPricePerNight *= 0.95;
                    }
                    else if (numberOfNights > 14)
                    {
                        studioPricePerNight *= 0.70;
                        apartmentPricePerNight *= 0.90;
                    }
                    
                    break;

                case "June":
                case "September":

                    studioPricePerNight = 75.20;
                    apartmentPricePerNight = 68.70;

                    if (numberOfNights > 14)
                    {
                        studioPricePerNight *= 0.80;
                        apartmentPricePerNight *= 0.90;
                    }
                    
                    break;

                case "July":
                case "August":

                    studioPricePerNight = 76.00;
                    apartmentPricePerNight = 77.00;

                    if (numberOfNights > 14)
                    {
                        apartmentPricePerNight *= 0.90;
                    }
                    
                    break;
            }

            double totalSumStudio = numberOfNights * studioPricePerNight;
            double totalSumApartment = numberOfNights * apartmentPricePerNight;

            Console.WriteLine($"Apartment: {totalSumApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalSumStudio:f2} lv.");

        }
    }
}
