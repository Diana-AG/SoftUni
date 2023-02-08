namespace Exercise3
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.Write($"Въведи текст: ");
            string input = Console.ReadLine();
            
            char letter = input[0];
            int letterAscii = input[0];
            int length = input.Length;

            Console.WriteLine($"Първата буква е: {letter}");
            Console.WriteLine($"Цифрова репрезентация (Ascii код) на първия символ: {letterAscii}");
            Console.WriteLine($"Дължината на текста е: {length}");
        }
    }
}
