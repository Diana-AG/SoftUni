namespace AreaOfFigures
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                area = sideA * sideA;
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = sideA * height / 2;
            }
            Console.WriteLine($"{area:f3}");             
        }
    }
}
