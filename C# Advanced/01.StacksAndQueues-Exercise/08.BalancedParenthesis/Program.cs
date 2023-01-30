using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isBalanced = true;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' ||
                    input[i] == '[' ||
                    input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == '}'||                    
                    input[i] == ']' ||
                    input[i] == ')')
                {
                    if (stack.Count < 1)
                    {
                        isBalanced = false;
                        break;
                    }

                    char previousParenthesis = stack.Pop();

                    if ((previousParenthesis == '{' && input[i] != '}') ||
                        (previousParenthesis == '[' && input[i] != ']') ||
                        (previousParenthesis == '(' && input[i] != ')') )
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0 || !isBalanced)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
