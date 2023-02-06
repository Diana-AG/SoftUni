namespace MetricConverter
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();
            string outputMeasure = Console.ReadLine();
            if (inputMeasure == "mm" && outputMeasure == "cm")
            {
                num /= 10;
            }
            if (inputMeasure == "cm" && outputMeasure == "mm")
            {
                num *= 10;
            }
            if (inputMeasure == "mm" && outputMeasure == "m")
            {
                num /= 1000;
            }
            if (inputMeasure == "m" && outputMeasure == "mm")
            {
                num *= 1000;
            }
            if (inputMeasure == "cm" && outputMeasure == "m")
            {
                num /= 100;
            }
            if (inputMeasure == "m" && outputMeasure == "cm")
            {
                num *= 100;
            }
            Console.WriteLine($"{num:f3}");
        }
    }
}
