namespace PetShop
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 реда:
            //1.Броят на кучетата – цяло число в интервала[0… 100]
            //2.Броят на останалите животни - цяло число в интервала[0… 100]
            int countOfDogs = int.Parse(Console.ReadLine());           
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            double priceFoodForDogs = 2.5;
            double priceFoodForOtherAnimals = 4;            
            double totalSum = countOfDogs * priceFoodForDogs + countOfOtherAnimals * priceFoodForOtherAnimals;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
