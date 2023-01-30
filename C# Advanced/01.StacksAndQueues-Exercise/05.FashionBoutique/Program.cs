using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(boxes);

            int capacity = int.Parse(Console.ReadLine());


            int rack = 0;

            while (stack.Count > 0)
            {
                int sum = 0;

                while (stack.Count > 0)
                {
                    if (sum + stack.Peek() > capacity)
                    {
                        break;
                    }
                    sum += stack.Pop();
                }

                rack++;
            }

            Console.WriteLine(rack);
        }
    }
}