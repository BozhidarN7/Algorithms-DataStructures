using System;
using System.Linq;

namespace SalesByMatch
{
    class SalesByMatch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] pairs = new int[101];

            for (int i = 0; i < n; i++)
            {
                pairs[arr[i]]++;
            }
            int result = 0;
            for (int i = 0; i < 101; i++)
            {
                if (pairs[i] != 0)
                {
                    result += pairs[i] / 2;
                }
            }
            Console.WriteLine(result);
        }
    }
}
