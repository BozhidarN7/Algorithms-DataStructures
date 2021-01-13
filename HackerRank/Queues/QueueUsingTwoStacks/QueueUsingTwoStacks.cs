using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueUsingTwoStacks
{
    class QueueUsingTwoStacks
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            Stack<int> rear = new Stack<int>();
            Stack<int> front = new Stack<int>();
            while (q > 0)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int operation = tokens[0];
                if (operation == 1)
                {
                    rear.Push(tokens[1]);
                }
                else
                {
                    if (front.Count == 0)
                    {
                        while (rear.Count != 0)
                        {
                            front.Push(rear.Pop());
                        }
                    }
                    if (front.Count != 0)
                    {
                        if (operation == 2)
                        {
                            front.Pop();
                        }
                        else
                        {
                            Console.WriteLine(front.Peek());
                        }
                    }
                }
                q--;
            }
        }
    }
}
