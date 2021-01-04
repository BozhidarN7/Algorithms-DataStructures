using System;
using System.Linq;

namespace CatsAndAMouse
{
    class CatsAndAMouse
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            while (q > 0)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = tokens[0];
                int y = tokens[1];
                int z = tokens[2];

                int catASteps = Math.Abs(x - z);
                int catBSteps = Math.Abs(y - z);

                if (catASteps < catBSteps)
                {
                    Console.WriteLine("Cat A");
                }
                else if (catBSteps < catASteps)
                {
                    Console.WriteLine("Cat B");
                }
                else
                {
                    Console.WriteLine("Mouse C");
                }

                q--;
            }
        }
    }
}
