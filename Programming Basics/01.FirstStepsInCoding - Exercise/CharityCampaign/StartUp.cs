namespace CharityCampaign
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double priceOfCake = 45;            
            double priceOfWaffel = 5.8;            
            double priceOfPancake = 3.2;
            double sumOneConfectionerPerDay = cakes * priceOfCake + waffles * priceOfWaffel + pancakes * priceOfPancake;
            double totalSum = day * confectioners * sumOneConfectionerPerDay;
            Console.WriteLine(totalSum - (totalSum / 8));
        }
    }
}