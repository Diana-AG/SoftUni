using System;

namespace _7.PascalTriangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            long[][] triangle = new long[height][];

            for (int i = 0; i < height; i++)
            {
                long[] currentRow = new long[i + 1];
                currentRow[0] = 1;
                currentRow[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    currentRow[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                triangle[i] = currentRow;
            }

            foreach (long[] row in triangle)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
