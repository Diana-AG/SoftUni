namespace _02.ExamPreparation2
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int counterPoorGrades = 0;
            int counter = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            int limit = int.Parse(Console.ReadLine());

            while (counterPoorGrades < limit)
            {
                string problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    counterPoorGrades++;
                }
                gradeSum += grade;
                counter++;
                lastProblem = problem;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {counterPoorGrades} poor grades.");
            }
            else
            {
                double averageScore = gradeSum / counter;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
