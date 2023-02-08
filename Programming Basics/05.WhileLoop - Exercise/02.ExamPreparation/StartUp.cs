namespace _02.ExamPreparation
{
    using System;
    using System.Threading;

    class StartUp
    {
        static void Main(string[] args)
        {
            double doubleConverter = 1.0;
            int PoorGradesLimit = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();            
            int gradeSum = 0;
            int counterGrades = 0;
            int counterPoorGrades = 0;
            string lastProblem = "";

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    counterPoorGrades++;
                }
                if (counterPoorGrades >= PoorGradesLimit)
                {
                    Console.WriteLine($"You need a break, {counterPoorGrades} poor grades.");
                    break;
                }
                counterGrades++;
                gradeSum += grade;
                lastProblem = problemName;
                problemName = Console.ReadLine();
            }
            if (problemName == "Enough")
            {
                double averageScore = doubleConverter * gradeSum / counterGrades;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {counterGrades}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
