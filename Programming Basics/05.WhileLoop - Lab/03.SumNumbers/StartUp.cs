﻿namespace _03.SumNumbers
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < num)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
