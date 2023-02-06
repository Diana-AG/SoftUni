namespace TradeCommissions
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string sity = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());


            switch (sity)
            {
                case "sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.05);
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.07);
                     }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.08);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.12);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.045);
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.075);
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.10);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.13);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.055);
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.08);
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.12);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 0.145);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
