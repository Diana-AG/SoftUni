namespace _05.Coins
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()) * 100;
            int cents = (int)input;
            int counter = 0;

            while (cents != 0)
            {
                if (cents >= 200)
                {
                    cents -= 200;
                    counter++;
                    continue;
                }
                if (cents >= 100)
                {
                    cents -= 100;
                    counter++;
                }
                if (cents >= 50)
                {
                    cents -= 50;
                    counter++;
                }
                if (cents >= 20)
                {
                    cents -= 20;
                    counter++;
                    continue;
                }
                if (cents >= 10)
                {
                    cents -= 10;
                    counter++;
                }
                if (cents >= 5)
                {
                    cents -= 5;
                    counter++;
                }
                if (cents >= 2)
                {
                    cents -= 2;
                    counter++;
                    continue;
                }
                if (cents >= 1)
                {
                    cents -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
