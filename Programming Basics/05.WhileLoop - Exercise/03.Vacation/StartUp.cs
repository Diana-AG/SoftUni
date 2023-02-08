namespace _03.Vacation
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingCounter = 0;



            while (ownedMoney < neededMoney && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                switch (action)
                {
                    case "spend":
                        ownedMoney -= sum;
                        spendingCounter++;
                        if (ownedMoney < 0)
                        {
                            ownedMoney = 0;
                        }
                        break;

                    case "save":
                        ownedMoney += sum;
                        spendingCounter = 0;
                        break;
                }
                days++;
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            if (spendingCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}
