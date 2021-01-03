using System;

namespace DrawingBook
{
    class DrawingBook
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if (p == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int leftPage = 2;
            int rightPage = 3;
            int turnsFromTheBeginning = 1;
            while (true)
            {
                if (leftPage == p || rightPage == p)
                {
                    break;
                }
                leftPage += 2;
                rightPage += 2;
                turnsFromTheBeginning++;
            }

            if (p == n || (n % 2 != 0 && n - 1 == p))
            {
                Console.WriteLine(0);
                return;
            }

            if (n % 2 == 0)
            {
                leftPage = n - 2;
                rightPage = n - 1;
            }
            else
            {
                leftPage = n - 2;
                rightPage = n - 2;
            }
            int turnsFromTheEnd = 0;
            while (true)
            {
                if (leftPage == p || rightPage == p)
                {
                    break;
                }
                leftPage -= 2;
                rightPage -= 2;
                turnsFromTheEnd++;
            }

            Console.WriteLine(Math.Max(turnsFromTheBeginning, turnsFromTheEnd));
        }
    }
}
