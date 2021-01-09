using System;
using System.Collections.Generic;

namespace FindDigits
{
    class FindDigits
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int number = int.Parse(Console.ReadLine());
                List<int> digits = GetDigits(number);
                int result = 0;
                for (int i = 0; i <digits.Count; i++)
                {
                    if (digits[i] != 0 && number % digits[i] == 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine(result);

                t--;
            }

        }

        private static List<int> GetDigits(int number)
        {
            List<int> digits = new List<int>();
            while (number != 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }
            return digits;
        }
    }
}
