using System;
using System.Text.RegularExpressions;

namespace SuperReducedString
{
    class SuperReducedString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Regex pattern = new Regex(@"([a-z])\1");
            MatchCollection matches = pattern.Matches(s);

            foreach (Match match in matches)
            {
                s = s.Replace(match.Groups[0].Value, string.Empty);
            }

            if (s == string.Empty)
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(s);
            }

        }
    }
}
