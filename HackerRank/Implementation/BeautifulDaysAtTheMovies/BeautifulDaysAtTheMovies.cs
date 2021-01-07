using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class BeautifulDaysAtTheMovies
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = tokens[0];

            int end = tokens[1];
            int k = tokens[2];

            int beautifulNumbers = 0;
            for (int i = start; i <= end; i++)
            {
                int reversedNumber = ReversNumber(i);
                if (Math.Abs(i - reversedNumber) % k == 0)
                {
                    beautifulNumbers++;
                }
            }
            Console.WriteLine(beautifulNumbers);
        }

        private static int ReversNumber(int number)
        {
            List<int> digits = new List<int>();
            while (number != 0)
            {
                int digit = number % 10;
                digits.Add(digit);
                number /= 10;
            }

            List<int> withoutTrailingZeros = digits.SkipWhile(x => x == 0).ToList();
            int newNumber = 0;
            for (int i = 0; i < withoutTrailingZeros.Count; i++)
            {
                newNumber += (int)Math.Pow(10, withoutTrailingZeros.Count - i - 1) * withoutTrailingZeros[i];
            }
            return newNumber;
        }
    }
}
