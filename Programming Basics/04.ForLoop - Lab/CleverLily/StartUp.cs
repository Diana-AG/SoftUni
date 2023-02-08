namespace CleverLily
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double mashinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            double presentMoney = 9;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += presentMoney;
                    presentMoney += 10;
                }
                else
                {
                    savedMoney += toysPrice;
                }
            }

            double diff = Math.Abs(savedMoney - mashinePrice);

            if (savedMoney >= mashinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
