using System;
using System.Linq;

namespace CutThesticks
{
    class CutThesticks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sticks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int remained = n;
            Console.WriteLine(remained);
            while (true)
            {
                int minLength = sticks.Where(x => x > 0).Min();
                for (int i = 0; i < n; i++)
                {
                    sticks[i] -= minLength;
                }
                remained = sticks.Where(x => x > 0).Count();

                if (remained == 0)
                {
                    break;
                }

                Console.WriteLine(remained);
            }
        }
    }
}
