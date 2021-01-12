using System;
using System.Linq;

namespace JumpingОnТheClouds
{
    class JumpingОnТheClouds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] clouds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int jumps = 0;
            int index = 0;
            while (index < n - 2)
            {
                if (clouds[index + 2] == 0)
                {
                    index += 2;
                }
                else if (clouds[index + 1] == 0)
                {
                    index += 1;
                }
                jumps++;
            }
            if (index == n - 2)
            {
                jumps++;
            }
            Console.WriteLine(jumps);
        }
    }
}
