using System;
using System.Linq;

namespace EqualizeTheArray
{
    class EqualizeTheArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] occ = new int[101];
            for (int i = 0; i < n; i++)
            {
                occ[arr[i]]++;
            }
            int mostCommonValue = occ.Max();
            int mostCommonElement = arr.Where(x => occ[x] == mostCommonValue).ToArray()[0];
            int removed = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i != mostCommonElement)
                {
                    removed += occ[i];
                }
            }
            Console.WriteLine(removed);
        }
    }
}
