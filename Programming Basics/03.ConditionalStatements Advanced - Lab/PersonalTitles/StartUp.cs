namespace PersonalTitles
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string title = "";

            if (gender == "f")
            {
                if (age >= 16)
                {
                    title = "Ms.";
                }
                else
                {
                    title = "Miss";
                }                
            }
            else
            {
                if (age >= 16)
                {
                    title = "Mr.";
                }
                else
                {
                    title = "Master";
                }
            }
            Console.WriteLine(title);
        }
    }
}
