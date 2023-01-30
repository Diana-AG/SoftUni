using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> stack = new Stack<string>();
            stack.Push(text);

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split();
                string operation = commandParts[0];

                if (operation == "1")
                {
                    text += commandParts[1];
                    stack.Push(text);
                }
                else if (operation == "2")
                {
                    int count = int.Parse(commandParts[1]);
                    text = text.Substring(0, text.Length - count);
                    stack.Push(text);
                } 
                else if (operation == "3")
                {
                    int index = int.Parse(commandParts[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (operation == "4")
                {
                    stack.Pop();
                    text = stack.Peek();
                }
            }
        }
    }
}
