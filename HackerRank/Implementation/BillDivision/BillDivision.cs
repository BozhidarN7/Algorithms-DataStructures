using System;
using System.Linq;

namespace BillDivision
{
    class BillDivision
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];

            int[] bills = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int chargedValue = int.Parse(Console.ReadLine());

            int totalSum = 0;
            for (int i = 0;i < bills.Length; i++)
            {
                if (k == i)
                {
                    continue;
                }

                totalSum += bills[i];
            }

            if (totalSum / 2== chargedValue)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(chargedValue  - totalSum /2);
            }
        }
    }
}
