namespace Journey
{
using System;
    using System.Globalization;

    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            string destination = "";
            string typeOfHoliday = "";
            double moneySpent = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (seson == "summer")
                {
                    typeOfHoliday = "Camp";
                    moneySpent = budget * 0.3;
                }
                else if (seson == "winter")
                {
                    typeOfHoliday = "Hotel";
                    moneySpent = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (seson == "summer")
                {
                    typeOfHoliday = "Camp"; 
                    moneySpent = budget * 0.4;
                }
                else if (seson == "winter")
                {
                    typeOfHoliday = "Hotel"; 
                    moneySpent = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                typeOfHoliday = "Hotel";
                moneySpent = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {moneySpent:f2}");
        }
    }
}
