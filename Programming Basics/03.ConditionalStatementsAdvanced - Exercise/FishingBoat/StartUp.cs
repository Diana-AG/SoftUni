namespace FishingBoat
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());

            double rent = 0.0;

            switch (seson)
            {
                case "Spring":
                    rent = 3000;
                    if (numberOfFisherman <= 6)
                    {
                        rent *= 0.9; 
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rent *= 0.85;
                    }
                    else
                    {
                        rent *= 0.75;
                    }
                    break;

                case "Summer":
                case "Autumn":
                    rent = 4200;
                    if (numberOfFisherman <= 6)
                    {
                        rent *= 0.9;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rent *= 0.85;
                    }
                    else
                    {
                        rent *= 0.75;
                    }
                    break;

                case "Winter":
                    rent = 2600;
                    if (numberOfFisherman <= 6)
                    {
                        rent *= 0.9;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rent *= 0.85;
                    }
                    else
                    {
                        rent *= 0.75;
                    }
                    break;
            }

            if (numberOfFisherman % 2 == 0)
            {
                if (seson == "Spring" || seson == "Summer" || seson == "Winter")
                {
                    rent *= 0.95;
                }
            }

            if (budget >= rent)
            {
                double moneyLeft = budget - rent;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = rent - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
            
        }
    }
}
