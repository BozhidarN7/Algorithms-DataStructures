using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class TwoStrings
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            for (int t = 0; t < p; t++)
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                HashSet<char> str1Characters = new HashSet<char>();
                GetCharacters(str1, str1Characters);

                HashSet<char> str2Characters = new HashSet<char>();
                GetCharacters(str2, str2Characters);

                Console.WriteLine(CheckForAtLeatOneCommonSymbol(str1Characters, str2Characters));

            }
        }

        private static string CheckForAtLeatOneCommonSymbol(HashSet<char> str1Characters, HashSet<char> str2Characters)
        {
            foreach (char symbol in str1Characters)
            {
                if (str2Characters.Contains(symbol))
                {
                    return "YES";
                }
            }

            return "NO";
        }

        private static void GetCharacters(string str, HashSet<char> set)
        {
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
        }
    }
}
