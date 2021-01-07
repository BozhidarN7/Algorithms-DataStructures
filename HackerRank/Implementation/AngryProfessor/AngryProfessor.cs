using System;
using System.Linq;

namespace AngryProfessor
{
    class AngryProfessor
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = tokens[0];
                int k = tokens[1];

                int[] arrivalTimes = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int late = 0;
                for (int i = 0; i < arrivalTimes.Length; i++)
                {
                    if (arrivalTimes[i] > 0)
                    {
                        late++;
                    }
                }
                int onTime = n - late;
                if (onTime >= k)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
                t--;
            }
        }
    }
}
