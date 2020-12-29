using System;
using System.Linq;

namespace EqualStacks
{
    class EqualStacks
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n1 = tokens[0];
            int n2 = tokens[1];
            int n3 = tokens[2];

            int[] stack1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stack2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stack3 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = FindMaxHeight(stack1, stack2, stack3, n1, n2, n3);

            Console.WriteLine(result);
        }

        private static int FindMaxHeight(int[] stack1, int[] stack2, int[] stack3, int n1, int n2, int n3)
        {
            int sum1 = CalculateSum(stack1, n1);
            int sum2 = CalculateSum(stack2, n2);
            int sum3 = CalculateSum(stack3, n3);

            int top1 = 0;
            int top2 = 0;
            int top3 = 0;

            while (true)
            {
                if (top1 == n1 || top2 == n2 || top3 == n3)
                {
                    return 0;
                }

                if (sum1 == sum2 && sum1 == sum3)
                {
                    return sum1;
                }

                if (sum1 > sum2 && sum1 > sum3)
                {
                    sum1 -= stack1[top1++];
                }
                else if (sum2 > sum1 && sum2 > sum3)
                {
                    sum2 -= stack2[top2++];
                }
                else if (sum3 > sum1 && sum3 > sum2)
                {
                    sum3 -= stack3[top3++];
                }
            }
        }

        private static int CalculateSum(int[] st, int len)
        {
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += st[i];
            }
            return sum;
        }
    }
}
