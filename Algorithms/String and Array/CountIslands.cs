using System;
namespace Algorithms.StringandArray
{
    public class CountIslands
    {
        public CountIslands()
        {
        }

        // Input: n x n grid with 0 or 1 value at each location
        // Output: Count of islands, where island is defined by a group of connected 1s in the graph.
        // Only vertical and horizontal adjacent 1s make up a connection. Diagonal does not count.
        public static int IslandCounter(int[,] array)
        {
            int islandCount = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] == 1)
                    {
                        islandCount++;
                        ExploreIsland(array, i, j);
                    }
                }
            }
            return islandCount;
        }

        // helper function to explore current island boundaries
        private static void ExploreIsland(int[,] array, int x, int y)
        {
            // if current grid location is in bounds, then explore it
            if (x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1))
            {
                if (array[x, y] == 1)
                {
					// flag current grid location as visited if it is part of island
					array[x, y] = -1;

                    // explore adjacent locations to determine boundaries of current island
                    ExploreIsland(array, x - 1, y);
                    ExploreIsland(array, x + 1, y);
                    ExploreIsland(array, x, y - 1);
                    ExploreIsland(array, x, y + 1);
                }
            }
        }
    }
}
