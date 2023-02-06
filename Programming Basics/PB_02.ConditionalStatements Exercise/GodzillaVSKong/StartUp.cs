namespace GodzillaVSKong
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int walkOn = int.Parse(Console.ReadLine());
            double priceClothesOneWalkOn = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double priceForClothes = 0.0;
            if (walkOn > 150)
            {
                priceForClothes = walkOn * priceClothesOneWalkOn * 0.9;
            }
            else
            {
                priceForClothes = walkOn * priceClothesOneWalkOn;
            }
            double expenses = decor + priceForClothes;
            double result = Math.Abs(budget - expenses);
            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {result:f2} leva more."); ;
            }


            //if (budget >= expenses)
            //{
            //    double moneyleft = budget - expenses;
            //    Console.WriteLine("Action!");
            //    Console.WriteLine($"Wingard starts filming with {moneyleft:f2} leva left.");
            //}
            //else
            //{
            //    double moneyNeeded = expenses - budget;
            //    Console.WriteLine("Not enough money!");
            //    Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            //}


        }
    }
}
