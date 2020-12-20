using System;

namespace MarsExploration
{
    class MarsExploration
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int count = 1;
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (count == 1 && s[i] != 'S')
                {
                    result++;
                }
                else if (count == 2 && s[i] != 'O')
                {
                    result++;
                }
                else if (count == 3 && s[i] != 'S')
                {
                    result++;
                }

                if (count == 3)
                {
                    count = 1;
                    continue;
                }
                count++;
            }

            Console.WriteLine(result);
        }
    }
}
