using System;
using System.Collections.Generic;

namespace SparseArrays
{
    class SparseArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> strings = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string cur = Console.ReadLine();
                if (!strings.ContainsKey(cur))
                {
                    strings.Add(cur, 0);
                }
                strings[cur]++;
            }

            int q = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            for (int i = 0; i < q; i++)
            {
                string cur = Console.ReadLine();
                if (strings.ContainsKey(cur))
                {
                    result.Add(strings[cur]);
                }
                else
                {
                    result.Add(0);
                }
            }
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
