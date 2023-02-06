namespace SkiTrip
{
using System;
    using System.Net.Http.Headers;

    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string rating = Console.ReadLine().ToLower();

            int nights = days - 1;

            const double priceRoomForOnePerson = 18.00;
            const double priceApartment = 25.00;
            const double pricePresidentApartment = 35.00;

            double holidayPrice = 0.0;

            switch (type)
            {
                case "room for one person":
                    holidayPrice = nights * priceRoomForOnePerson;
                    break;

                case "apartment":

                    holidayPrice = nights * priceApartment;

                    if (days < 10)
                    {
                        holidayPrice *=  0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        holidayPrice *= 0.65;
                    }
                    else if (days > 15)
                    {
                        holidayPrice *= 0.50;
                    }                    
                    break;

                case "president apartment":

                    holidayPrice = nights * pricePresidentApartment;

                    if (days < 10)
                    {
                        holidayPrice *= 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        holidayPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        holidayPrice *= 0.80;
                    }
                    break;
            }
            switch (rating)
            {
                case "positive":
                    holidayPrice *= 1.25;
                    break;

                case "negative":
                    holidayPrice *= 0.90;
                    break;
            }
            Console.WriteLine("{0:f2}", holidayPrice);
        }
    }
}
