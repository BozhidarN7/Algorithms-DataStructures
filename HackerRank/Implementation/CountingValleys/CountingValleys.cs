using System;

namespace CountingValleys
{
    class CountingValleys
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string path = Console.ReadLine();

            int stepsDown = 0;
            int stepsUp = 0;
            int valleys = 0;
            for (int i = 0; i < n; i++)
            {
                if (path[i] == 'U' && stepsUp >= stepsDown)
                {
                    stepsUp++;
                }
                else if (path[i] == 'U' && stepsUp < stepsDown)
                {
                    stepsUp++;
                    stepsDown--;
                }
                else if (path[i] == 'D' && stepsDown >= stepsUp)
                {
                    stepsDown++;
                    stepsUp--;

                }
                else if (path[i] == 'D' && stepsUp > stepsDown)
                {
                    stepsUp--;
                }

                if (path[i] == 'U' && stepsUp == stepsDown && stepsDown == 0)
                {
                    valleys++;
                }
            }

            Console.WriteLine(valleys);
        }
    }
}
