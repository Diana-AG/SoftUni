namespace PetShop
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            double priceFoodForDogs = 2.5;
            double priceFoodForOtherAnimals = 4;            
            double totalSum = countOfDogs * priceFoodForDogs + countOfOtherAnimals * priceFoodForOtherAnimals;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
