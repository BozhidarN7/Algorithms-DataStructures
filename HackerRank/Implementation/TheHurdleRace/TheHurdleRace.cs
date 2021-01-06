using System;
using System.Linq;

namespace TheHurdleRace
{
    class TheHurdleRace
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];

            int[] heights = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(heights.Max() - k > 0 ? heights.Max() - k : 0);
        }
    }
}
