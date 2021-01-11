using System;
using System.Linq;
using System.Numerics;

namespace RepeatedString
{
    class RepeatedString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());

            long a = s.Where(x => x == 'a').Count();
            long repetitions = n % s.Length == 0 ? n / s.Length : n / s.Length + 1;
            long skip = (repetitions * s.Length) % n;
            long total = repetitions * a;
            for (int i = Convert.ToInt32(s.Length - skip); i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    total--;
                }
            }

            Console.WriteLine(total);
        }
    }
}
