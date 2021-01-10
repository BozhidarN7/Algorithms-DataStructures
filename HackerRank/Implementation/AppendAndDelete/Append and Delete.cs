using System;

namespace AppendAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int equalCharacters = 0;
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < s.Length; i++)
            {
                if (i < t.Length && s[i] == t[i])
                {
                    equalCharacters++;
                }
                else
                {
                    break;
                }
            }
            if (s.Length + t.Length - 2 * equalCharacters > k)
            {
                Console.WriteLine("No");
            }
            else if ((s.Length + t.Length - 2 * equalCharacters) % 2 == k % 2)
            {
                Console.WriteLine("Yes");
            }
            else if ((s.Length + t.Length - k) < 0)
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
