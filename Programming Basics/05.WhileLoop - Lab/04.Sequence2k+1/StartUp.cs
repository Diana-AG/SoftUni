namespace _04.Sequence2k_1
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int output = 1;

            while (output <= num)
            {
                Console.WriteLine(output);
                output = output * 2 + 1;
            }
        }
    }
}
