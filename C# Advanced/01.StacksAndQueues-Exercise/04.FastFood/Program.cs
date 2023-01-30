using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] sequanceOfQuantity = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(sequanceOfQuantity);

            Console.WriteLine(orders.Max());

            if (orders.Sum() <= quantity)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                int sum = 0;
                while (sum + orders.Peek() <= quantity)
                {
                    sum += orders.Dequeue();
                }

                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }


            //int foodQuantity = int.Parse(Console.ReadLine());

            //int[] orders = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //Queue<int> queue = new Queue<int>(orders);

            //Console.WriteLine(queue.Max());

            //int sum = 0;

            //while (queue.Count > 0)
            //{
            //    int firstInLine = queue.Peek();

            //    sum += firstInLine;

            //    if (sum <= foodQuantity)
            //    {
            //        queue.Dequeue();
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Orders left: {string.Join(' ', queue)}.");
            //        return;
            //    }
            //}

            //Console.WriteLine($"Orders complete");
        }
    }
}
