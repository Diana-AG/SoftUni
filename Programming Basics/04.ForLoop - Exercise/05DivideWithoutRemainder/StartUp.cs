﻿namespace _05DivideWithoutRemainder
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            const double doubleConv = 1.0;

            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double pp1 = doubleConv * p1 / n * 100;
            double pp2 = doubleConv * p2 / n * 100;
            double pp3 = doubleConv * p3 / n * 100;

            Console.WriteLine($"{pp1:f2}%");            
            Console.WriteLine($"{pp2:f2}%");            
            Console.WriteLine($"{pp3:f2}%");            
        }
    }
}