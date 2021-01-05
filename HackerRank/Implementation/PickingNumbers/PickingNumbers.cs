using System;
using System.Linq;

namespace PickingNumbers
{
    class PickingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] occ = new int[100];
            for (int i = 0; i < n; i++)
            {
                occ[arr[i]]++;
            }
            int result = 0;
            for (int i = 0; i < n -1; i++)
            {
                if (occ[i] + occ[i +1]> result)
                {
                    result = occ[i] + occ[i + 1];
                }
            }

            Console.WriteLine(result);
        }
    }
}
