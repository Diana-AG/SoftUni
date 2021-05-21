using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = numbers.Dequeue();

                if (currentNumber % 2 == 0)
                {
                    numbers.Enqueue(currentNumber);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
