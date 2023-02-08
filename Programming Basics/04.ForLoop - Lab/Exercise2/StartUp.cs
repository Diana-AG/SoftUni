namespace Exercise2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи текст: ");
            string input = Console.ReadLine();
            int length = input.Length;
            char firstLetter = input[0];
            int asciiNum = input[0]; ;

            Console.WriteLine($"Дължинта на въведения текст е: {length}");
            Console.WriteLine($"Първата буква от въведения текст е: {firstLetter}");
            Console.WriteLine($"Числовата репрезентация на първия символ от текста е: {asciiNum:d3}");


            int n = 1;
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Буква {n}: {input[i]}");
                n++;
            }
            Console.WriteLine("Числовата репрезентация на символите");
            
            for (int j = 0; j < input.Length; j++)
            {
                int currentLetterValue = input[j];
                Console.WriteLine($"{input[j]}: {currentLetterValue}");
            }

            //int price = 0;

            //if (input.Length > 8)
            //{
            //    price = input[0];
            //    price += input[1];
            //} 
        }
    }
}