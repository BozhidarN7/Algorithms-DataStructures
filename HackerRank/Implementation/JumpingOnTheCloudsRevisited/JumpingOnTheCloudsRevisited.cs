using System;
using System.Linq;

namespace JumpingOnTheCloudsRevisited
{
    class JumpingOnTheCloudsRevisited
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];
            int energy = 100;
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = k % n;
            while (index != 0)
            {
                energy = CalculateEnergyLost(arr, index, energy);
                index = (index + k) % n;
            }
            energy = CalculateEnergyLost(arr, index, energy);

            Console.WriteLine(energy);
        }
        private static int CalculateEnergyLost(int[] arr, int index, int energy)
        {
            energy -= 1;
            if (arr[index] == 1)
            {
                energy -= 2;
            }
            return energy;
        }
    }
}
