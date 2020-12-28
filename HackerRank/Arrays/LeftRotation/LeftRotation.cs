using System;
using System.Linq;
namespace LeftRotation
{
    class LeftRotation
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int d = tokens[1];

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] newArr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                int index = i - d % arr.Length >= 0 ? i - d : arr.Length - (d - i) % arr.Length ;
                newArr[index] = arr[i];
            }

            Console.WriteLine(string.Join(" ", newArr));

        }
    }
}
