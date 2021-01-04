using System;

namespace DrawingBook
{
    class DrawingBook
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(p / 2, n / 2 - p / 2));
        }
    }
}
