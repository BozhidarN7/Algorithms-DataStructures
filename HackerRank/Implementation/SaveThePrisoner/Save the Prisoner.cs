using System;
using System.Linq;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = tokens[0];
                int m = tokens[1];
                int s = tokens[2];

                int chairNumber = (s - 1 + m - 1 )%n;
                Console.WriteLine(chairNumber + 1);

                t--;
            }
        }
    }
}
