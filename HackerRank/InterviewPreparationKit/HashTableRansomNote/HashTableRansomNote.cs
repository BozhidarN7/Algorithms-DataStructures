using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableRansomNote
{
    class HashTableRansomNote
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int m = input[0];
            int n = input[1];

            Dictionary<string, int> magazineWords = new Dictionary<string, int>();
            ReadInput(magazineWords, m);

            Dictionary<string, int> noteWords = new Dictionary<string, int>();
            ReadInput(noteWords, n);

            Console.WriteLine(CheckMagazine(noteWords, magazineWords));
        }

        private static string CheckMagazine(Dictionary<string, int> noteWords, Dictionary<string, int> magazineWords)
        {
            foreach (KeyValuePair<string,int> kvp in noteWords)
            {
                if (!magazineWords.ContainsKey(kvp.Key))
                {
                    return "No";
                }

                if (magazineWords[kvp.Key] < kvp.Value)
                {
                    return "No";
                }
            }

            return "Yes ";
        }
        private static void ReadInput(Dictionary<string, int> dic, int n)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            for (int i = 0; i < n; i++)
            {
                string word = words[i];

                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 0);
                }

                dic[word]++;
            }
        }
    }
}
