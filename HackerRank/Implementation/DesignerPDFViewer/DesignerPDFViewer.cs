using System;
using System.Linq;

namespace DesignerPDFViewer
{
    class DesignerPDFViewer
    {
        static void Main(string[] args)
        {
            int[] heights = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            int maxHeight = 0;
            for (int i = 0; i < word.Length; i++)
            {
                maxHeight = Math.Max(heights[word[i] - 'a'], maxHeight);
            }

            Console.WriteLine(maxHeight * word.Length);
        }
    }
}
