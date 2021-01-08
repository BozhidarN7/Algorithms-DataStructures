using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLikes = 0;
            int people = 5;
            for (int i = 1; i <= n; i++)
            {
                int newLikes = (int)Math.Floor((decimal)people / 2);
                totalLikes += newLikes;
                people = newLikes * 3;
            }
            Console.WriteLine(totalLikes);
        }
    }
}
