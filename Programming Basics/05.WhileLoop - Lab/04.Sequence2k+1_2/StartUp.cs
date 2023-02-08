namespace _04.Sequence2k_1_2
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 1;

            while (true)
            {
                if (output > n)
                {
                    break;
                }
                Console.WriteLine(output);
                output = output * 2 + 1;
            }
        }
    }
}
