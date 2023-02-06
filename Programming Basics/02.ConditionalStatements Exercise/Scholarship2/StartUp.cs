namespace Scholarship
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarshipForExcellentResults = Math.Floor(score * 25);
            double socialScholarship = Math.Floor(minimalSalary * 0.35);

            if (score <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (score >= 5.50 && income < minimalSalary)
            {
                if (socialScholarship > scholarshipForExcellentResults)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResults} BGN");
                }
            }
            else if (score >= 5.50 && income >= minimalSalary)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResults} BGN");
            }
            else
            {
                if (income < minimalSalary)
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
}
