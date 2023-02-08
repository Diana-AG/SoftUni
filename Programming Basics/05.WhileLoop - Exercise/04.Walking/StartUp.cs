namespace _04.Walking
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            int stepsCounter = 0;            
            string command = Console.ReadLine();

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                stepsCounter += steps;
                if (stepsCounter >= goal)
                {
                    break;
                }
                command = Console.ReadLine();
            }
             if (command == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                stepsCounter += stepsToHome;
            }
            int diff = Math.Abs(stepsCounter - goal);
            if (stepsCounter >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
