namespace ProjectsCreation
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());
            int hoursNeededForOneProject = 3;
            int hoursForAllProjects = countOfProjects * hoursNeededForOneProject;
            Console.WriteLine($"The architect {name} will need {hoursForAllProjects} hours to complete {countOfProjects} project/s.");
        }
    }
}
