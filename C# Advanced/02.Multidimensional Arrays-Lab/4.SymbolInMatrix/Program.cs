using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            bool isFind = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentCol = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            char line = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == line)
                    {
                        isFind = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
            }

            if (!isFind)
            {
                Console.WriteLine($"{line} does not occur in the matrix");
            }
        }
    }
}
