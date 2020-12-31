using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> lastState = new Stack<string>();
            while (q > 0)
            {
                string[] tokens = Console.ReadLine().Split();
                int command = int.Parse(tokens[0]);
                if (command == 1)
                {
                    lastState.Push(text);
                    text += tokens[1];
                }
                else if (command == 2)
                {
                    int k = int.Parse(tokens[1]);
                    lastState.Push(text);
                    text = text.Remove(text.Length - k);
                }
                else if (command == 3)
                {
                    int k = int.Parse(tokens[1]);
                    Console.WriteLine(text[k - 1]);
                }
                else
                {
                    if (lastState.Count != 0)
                    {
                        text = lastState.Pop();
                    }

                }
                q--;
            }
        }
    }
}
