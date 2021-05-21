using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNumbers = new Stack<int>(inputNumbers);

            string command;

            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandParts[0] == "ADD")
                {
                    stackNumbers.Push(int.Parse(commandParts[1]));
                    stackNumbers.Push(int.Parse(commandParts[2]));
                }
                else
                {
                    int count = int.Parse(commandParts[1]);
                    if (stackNumbers.Count < count)
                    {
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        stackNumbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
