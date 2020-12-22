using System;

namespace SeparateTheNumbers
{
    class SeparateTheNumbers
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            while (q != 0)
            {
                string s = Console.ReadLine();



                int firstNumber = s[0] - '0';
                int index = 1;
                int length = 1;
                int nextNumber = 0;

                while (true)
                {
                    nextNumber = int.Parse(s.Substring(index, length));
                    if (firstNumber == nextNumber - 1)
                    {
                        break;
                    }
                    else
                    {
                        firstNumber = firstNumber * 10 + (int)(s[index] - '0');
                        length++;
                        index++;
                    }
                }
                Console.WriteLine(firstNumber);

                q--;
            }
        }
    }
}
