namespace Scholarship
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            
            double scholarshipForExcellentResults = Math.Floor(score * 25);
            double socialScholarship = Math.Floor(minSalary * 0.35);

            if (score >= 5.5 && income < minSalary && socialScholarship <= scholarshipForExcellentResults)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResults} BGN");
            }
            else if (score >= 5.5 && income < minSalary && socialScholarship > scholarshipForExcellentResults)
            {
                Console.WriteLine($"You get a scholarship for excellent results {socialScholarship} BGN");
            }
            else if (score > 4.5 && income < minSalary)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
