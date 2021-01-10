using System;
using System.Linq;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            while (q > 0)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int start = tokens[0];
                int end = tokens[1];

                int number = (int)Math.Ceiling(Math.Sqrt(start));
                int squareNumber = number * number;
                number = (number * 2) + 1;
                int count = 0;
                while (squareNumber >= start && squareNumber <= end)
                {
                    count++;
                    squareNumber += number;
                    number += 2;
                }
                Console.WriteLine(count);
                q--;
            }

        }
    }
}
