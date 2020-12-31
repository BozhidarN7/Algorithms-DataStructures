using System;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool areBalanced = AreBalanced(input);

                if (areBalanced)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        private static bool AreBalanced(string input)
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (brackets.Count == 0 && (input[i] == ')' || input[i] == ']' || input[i] == '}'))
                {
                    return false;
                }

                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    brackets.Push(input[i]);
                }
                else
                {
                    if (input[i] == ')' && brackets.Peek() != '(')
                    {
                        return false;
                    }
                    else if (input[i] == ']' && brackets.Peek() != '[')
                    {
                        return false;
                    }
                    else if (input[i] == '}' && brackets.Peek() != '{')
                    {
                        return false;
                    }
                    else if (brackets.Count != 0 && input[i] == ')' && brackets.Peek() == '(')
                    {
                        brackets.Pop();
                    }
                    else if (brackets.Count != 0 && input[i] == ']' && brackets.Peek() == '[')
                    {
                        brackets.Pop();
                    }
                    else if (brackets.Count != 0 && input[i] == '}' && brackets.Peek() == '{')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (brackets.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
