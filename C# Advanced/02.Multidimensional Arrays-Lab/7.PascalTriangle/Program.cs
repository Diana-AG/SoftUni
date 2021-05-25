using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            long[][] triangle = new long[height][];

            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;

                //if (triangle[i].Length > 2)
                //{
                    for (int j = 1; j < triangle[i].Length - 1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }

                //}
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(string.Join(' ', triangle[i]));
            }
        }
    }
}
