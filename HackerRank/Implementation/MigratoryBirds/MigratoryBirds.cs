using System;
using System.Linq;

namespace MigratoryBirds
{
    class MigratoryBirds
    {
        private const int TYPES = 5;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] types = new int[TYPES + 1];

            for (int i = 0; i < n; i++)
            {
                types[arr[i]]++;
            }

            int mostCommon = types.Max();
            for (int i = 1; i <= TYPES; i++)
            {
                if (types[i] == mostCommon)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
