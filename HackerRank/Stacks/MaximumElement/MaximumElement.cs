using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();
            Stack<int> trackSTack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int type = tokens[0];

                if (type == 1 && st.Count == 0)
                {
                    st.Push(tokens[1]);
                    trackSTack.Push(tokens[1]);
                }
                else if (type == 1)
                {
                    st.Push(tokens[1]);
                    if (tokens[1] > trackSTack.Peek())
                    {
                        trackSTack.Push(tokens[1]);
                    }
                    else
                    {
                        trackSTack.Push(trackSTack.Peek());
                    }
                }
                else if (type == 2)
                {
                    st.Pop();
                    trackSTack.Pop();
                }
                else
                {
                    Console.WriteLine(trackSTack.Peek());
                }
            }
        }
    }
}
