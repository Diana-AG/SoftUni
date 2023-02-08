namespace _08.GraduationPt._2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = 1;
            double sum = 0;
            int excluded = 0;
            while (n <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    excluded++;
                    if (excluded > 1)
                    {
                        break;
                    }
                    continue;
                }
                sum += grade;
                n++;
            }
            if (excluded <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {n} grade");
            }
        }
    }
}
