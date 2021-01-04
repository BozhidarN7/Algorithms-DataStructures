using System;
using System.Linq;

namespace ElectronicsShop
{
    class ElectronicsShop
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int b = tokens[0];
            int n = tokens[1];
            int m = tokens[2];
            int[] keyboards = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] drives = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int mostExpensive = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (keyboards[i] + drives[j] <= b)
                    {
                        mostExpensive = Math.Max(mostExpensive, keyboards[i] + drives[j]);
                    }
                }
            }
            if (mostExpensive != 0)
            {
                Console.WriteLine(mostExpensive);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
