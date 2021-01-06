using System;

namespace UtopianTree
{
    class UtopianTree
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int height = 1;
                int season = 0; // 0 - spring, 1 - summer
                for (int i = 0; i< n; i++)
                {
                    if (season == 0)
                    {
                        height *= 2;
                        season = 1;
                    }
                    else if( season == 1)
                    {
                        height += 1;
                        season = 0;
                    }
                }
                Console.WriteLine(height);
                t--;
            }
        }
    }
}
