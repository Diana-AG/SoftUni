﻿namespace InvalidNumber
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100 && num != 0 || num > 200 )
            {
                Console.WriteLine("invalid");
            }
                        
        }
    }
}
 