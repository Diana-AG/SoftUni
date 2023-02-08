namespace _05.Coins2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()) * 100;
            int cents = (int)input;
            int coins = 0;

            while (cents != 0)
            {
                if (cents >= 200)
                {
                    while (cents >= 200)
                    {
                        cents -= 200;
                        coins++;
                    }
                }
                if (cents >= 100)
                {
                    cents -= 100;
                    coins++;
                }
                if (cents >= 50)
                {
                    cents -= 50;
                    coins++;
                }
                if (cents >= 20)
                    while (cents >= 20)
                    {
                        cents -= 20;
                        coins++;
                    }
                if (cents >= 10)
                {
                    cents -= 10;
                    coins++;
                }
                if (cents >= 5)
                {
                    cents -= 5;
                    coins++;
                }
                if (cents >= 2)
                {
                    while (cents >= 2)
                    {
                        cents -= 2;
                        coins++;
                    }
                }
                if (cents >= 1)
                {
                    cents -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
