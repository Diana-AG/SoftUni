namespace _01.OldBooks
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            

            while (currentBook != "No More Books")
            {
                if (currentBook == wantedBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                currentBook = Console.ReadLine();
            }
            
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
