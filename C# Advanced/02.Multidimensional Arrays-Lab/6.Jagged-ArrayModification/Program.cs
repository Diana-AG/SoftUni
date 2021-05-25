using System;
using System.Linq;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = ReadArrayFromConsole();
            }

            string command;

            while ((command = Console.ReadLine()).ToUpper() != "END")
            {
                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (row < 0 ||
                    row >= n ||
                    col < 0 ||
                    col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (commandParts[0])
                {
                    case "Add":
                        jagged[row][col] += value;                    
                        break;

                    case "Subtract":
                        jagged[row][col] -= value;
                        break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', jagged[i]));
            }
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}
