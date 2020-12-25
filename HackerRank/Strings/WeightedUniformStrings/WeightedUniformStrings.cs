using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WeightedUniformStrings
{
    class WeightedUniformStrings
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HashSet<int> sums = new HashSet<int>();
            for (int i = 0; i < s.Length; i++)
            {
                sums.Add(s[i] - 'a' + 1);
            }

            Regex pattern = new Regex(@"([a-z])\1{2,}");
            MatchCollection matches = pattern.Matches(s);
            foreach (Match match in matches)
            {
                for (int i = 1; i < match.Value.Length; i++)
                {
                    sums.Add((match.Value[0] - 'a' + 1) * (i + 1));
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (sums.Contains(x))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
