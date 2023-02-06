namespace DepositCalculator
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int termOfTheDeposit = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());
            double sum = depositAmount + termOfTheDeposit * ((depositAmount * annualRate / 100) / 12);
            Console.WriteLine(sum);
        }
    }
}
