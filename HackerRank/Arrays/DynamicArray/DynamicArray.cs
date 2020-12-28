using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int q = tokens[1];

            List<int>[] arr = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new List<int>();
            }
            int lastAnswer = 0;
            while (q != 0)
            {
                tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int type = tokens[0];
                int x = tokens[1];
                int y = tokens[2];

                if (type == 1)
                {
                    int index = (x ^ lastAnswer) % n;
                    arr[index].Add(y);
                }
                else
                {
                    int index = (x ^ lastAnswer) % n;
                    lastAnswer = arr[index][y % arr[index].Count];
                    Console.WriteLine(lastAnswer);
                }

                q--;
            }
        }
    }
}
