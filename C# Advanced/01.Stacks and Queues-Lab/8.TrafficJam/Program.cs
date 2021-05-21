using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int counter = 0;

            string line;

            while ((line = Console.ReadLine()) != "end")
            {
                if (line == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count <= 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                    continue;
                }

                queue.Enqueue(line);
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
