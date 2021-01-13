using System;
using System.Collections.Generic;
using System.Linq;

namespace CastleOnTheGrid
{
    class CastleOnTheGrid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            bool[][] visited = new bool[n][];
            int[][] paths = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                visited[i] = new bool[n];
                paths[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    paths[i][j] = int.MaxValue;
                }
            }
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startRow = tokens[0];
            int startCol = tokens[1];
            int endRow = tokens[2];
            int endCol = tokens[3];
            int pathLength = 0;
            
            Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
            queue.Enqueue(new KeyValuePair<int, int>(startRow, startCol));
            while (queue.Count != 0)
            {
                KeyValuePair<int, int> currentCell = queue.Dequeue();
                visited[currentCell.Key][currentCell.Value] = true;

                pathLength = GetCurrentPathLength(paths, currentCell.Key, currentCell.Value, pathLength);
                MarkAsVisitedSameRowAndCol(matrix, paths, visited, currentCell.Key, currentCell.Value, pathLength);

                if (currentCell.Key == endRow && currentCell.Value == endCol)
                {
                    pathLength = paths[currentCell.Key][currentCell.Value];
                    break;
                }

                int[] rows = { 1, -1, 0, 0 };
                int[] cols = { 0, 0, 1, -1 };

                for (int i = 0; i < rows.Length; i++)
                {
                    int nextCellRow = currentCell.Key + rows[i];
                    int nextCellCol = currentCell.Value + cols[i];

                    if (nextCellCol >= 0 && nextCellCol < n && nextCellRow >= 0 && nextCellRow < n
                        && matrix[nextCellRow][nextCellCol] != 'X' && !visited[nextCellRow][nextCellCol])
                    {
                        queue.Enqueue(new KeyValuePair<int, int>(nextCellRow, nextCellCol));
                    }
                }
            }
            Console.WriteLine(pathLength);
        }

        private static int GetCurrentPathLength(int[][] paths, int row, int col,int pathLength)
        {
            if (row - 1 >= 0)
            {
                pathLength = Math.Min(pathLength, paths[row - 1][col]);
            }
            if (row + 1 < paths.Length)
            {
                pathLength = Math.Min(pathLength, paths[row + 1][col]);
            }
            if (col - 1 >= 0)
            {
                pathLength = Math.Min(pathLength, paths[row][col - 1]);
            }
            if (col + 1 < paths.Length)
            {
                pathLength = Math.Min(pathLength, paths[row][col + 1]);
            }
            return pathLength + 1;
        }

        private static void MarkAsVisitedSameRowAndCol(char[][] matrix, int[][] paths, bool[][] visited, int startRow, int startCol, int pathLength)
        {
            for (int i = startRow; i < matrix.Length; i++)
            {
                if (matrix[i][startCol] == 'X') break;
                paths[i][startCol] = Math.Min(pathLength, paths[i][startCol]);
            }
            for (int i = startRow; i >= 0; i--)
            {
                if (matrix[i][startCol] == 'X') break;
                paths[i][startCol] = Math.Min(pathLength, paths[i][startCol]);
            }
            for (int j = startCol; j < matrix.Length; j++)
            {
                if (matrix[startRow][j] == 'X') break;

                paths[startRow][j] = Math.Min(pathLength, paths[startRow][j]);
            }
            for (int j = startCol; j >= 0; j--)
            {
                if (matrix[startRow][j] == 'X') break;
                paths[startRow][j] = Math.Min(pathLength, paths[startRow][j]);
            }
        }
    }
}
