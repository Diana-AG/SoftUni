using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "1")
                {
                    stack.Push(int.Parse(line[1]));
                }
                else if (line[0] == "2" && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (line[0] == "3" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (line[0] == "4" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
