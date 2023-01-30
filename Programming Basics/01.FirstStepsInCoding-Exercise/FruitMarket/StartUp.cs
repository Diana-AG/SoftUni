namespace FruitMarket
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double kgBananas = double.Parse(Console.ReadLine());
            double kgOranges = double.Parse(Console.ReadLine());
            double kgRaspberries = double.Parse(Console.ReadLine());
            double kgStrawberries = double.Parse(Console.ReadLine());
            double priceRaspberries = priceStrawberries / 2;
            double priceOranges = priceRaspberries * 0.6;
            double priceBananas = priceRaspberries * 0.2;
            Console.WriteLine($"{(kgStrawberries * priceStrawberries + kgBananas * priceBananas + kgOranges * priceOranges + kgRaspberries * priceRaspberries):f2}");
        }
    }
}