namespace Cinema
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            const double premierTicket = 12.00;
            const double normalTicket = 7.50;
            const double discountTicket = 5.00;

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = rows * colums * premierTicket;
            }
            else if (type == "Normal")
            {
                income = rows * colums * normalTicket;
            }
            else if (type == "Discount")
            {
                income = rows * colums * discountTicket;
            }

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
