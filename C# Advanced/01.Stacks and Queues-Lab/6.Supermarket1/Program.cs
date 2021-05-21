using System;
using System.Collections.Generic;

namespace _6.Supermarket1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string line;

            while ((line = Console.ReadLine()).ToUpper() != "END")
            {
                if (line.ToUpper() == "PAID")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    continue;
                }

                queue.Enqueue(line);
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
