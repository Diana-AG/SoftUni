namespace ToyShop
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            const double puzzlesPrice = 2.60;
            const double talkingDollPrice = 3.00;
            const double teddyBearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2.00; 
            double priceOfTheExcursion = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            int totalToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;
            double totalPrice = numberOfPuzzles * puzzlesPrice + numberOfTalkingDolls * talkingDollPrice + numberOfTeddyBears * teddyBearPrice + numberOfMinions * minionPrice + numberOfTrucks * truckPrice;
            double earnedMoney = 0;
            if (totalToys >= 50)
            {
                earnedMoney = totalPrice * 0.75;
            }
            else
            {
                earnedMoney = totalPrice;
            }           
            
            double earnedMoneyAfterRent = earnedMoney * 0.90;
            if (earnedMoneyAfterRent >= priceOfTheExcursion)
            {
                double moneyLeft = earnedMoneyAfterRent - priceOfTheExcursion;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceOfTheExcursion - earnedMoneyAfterRent;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
             
        }
    }
}