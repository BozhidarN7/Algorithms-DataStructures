using System;
using System.Linq;
namespace Pangrams
{
    class Pangrams
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool[] letters = new bool[26];

            for (int i = 0; i < s.Length;i++)
            {
                if (char.ToLower(s[i]) >= 'a' && char.ToLower(s[i]) <= 'z')
                {
                    letters[char.ToLower(s[i]) - 'a'] = true;
                }
            }

            if (letters.All(x => x == true))
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
    }
}
