using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Supermarket
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
                    Console.WriteLine(string.Join(Environment.NewLine, queue));
                    queue.Clear();
                    continue;
                }

                queue.Enqueue(line);
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
