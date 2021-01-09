using System;
using System.Linq;

namespace SequenceEquation
{
    class SequenceEquation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = i + 1;
                int neededNumber = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] == currentNumber)
                    {
                        neededNumber = j + 1;
                        break;
                    }
                }
                int y = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] == neededNumber)
                    {
                        y = j + 1;
                        break;
                    }
                }
                Console.WriteLine(y);
            }
        }
    }
}
