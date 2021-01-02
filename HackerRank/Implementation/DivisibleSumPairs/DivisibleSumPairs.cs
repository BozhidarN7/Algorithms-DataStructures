using System;
using System.Linq;

namespace DivisibleSumPairs
{
    class DivisibleSumPairs
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((arr[i] + arr[j]) % k == 0)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
