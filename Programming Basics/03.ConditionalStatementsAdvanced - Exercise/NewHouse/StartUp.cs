namespace NewHouse
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rosesPrice = 5.00;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3.00;
            const double gladiolusPrice = 2.50;
            
            double totalPrice = 0.0;

            switch (typeOfFlower)
            {
                case "Roses":
                    totalPrice = num * rosesPrice;
                    if (num > 80)
                    {
                        totalPrice *= 0.90;
                    }
                    break;

                case "Dahlias":
                    totalPrice = num * dahliasPrice;
                    if (num > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;

                case "Tulips":
                    totalPrice = num * tulipsPrice;
                    if (num > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;

                case "Narcissus":
                    totalPrice = num * narcissusPrice;
                    if (num < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;

                case "Gladiolus":
                    totalPrice = num * gladiolusPrice;
                    if (num < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
            }

            if (totalPrice <= budget)
            {

                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {num} {typeOfFlower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
                
        }
    }
}
