using System;
using System.Linq;

namespace CircularArrayRotation
{
    class CircularArrayRotation
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];
            int q = tokens[2];

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rotatedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotatedArr[(i + k) % n] = arr[i];
            }

            while (q > 0)
            {
                int query = int.Parse(Console.ReadLine());
                Console.WriteLine(rotatedArr[query]);
                q--;

            }
        }
    }
}
