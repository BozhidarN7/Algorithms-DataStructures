using System;

namespace HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            string pattern = "hackerrank";
            for (int q = 0; q < queries; q++)
            {
                bool contains = false;
                string s = Console.ReadLine();
                int patternIndex = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == pattern[patternIndex])
                    {
                        patternIndex++;
                    }

                    if (patternIndex == pattern.Length - 1)
                    {
                        Console.WriteLine("YES");
                        contains = true;
                        break;
                    }
                }

                if (!contains)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
