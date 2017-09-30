using System;
using System.Collections.Generic;
namespace Algorithms.StringandArray
{
    public class RottenOranges
    {
		// Given a matrix of dimension r*c where each cell in the matrix can have values 0, 1 or 2 which has the following meaning:

        //0: Empty cell
        //1: Cells have fresh oranges
        //2: Cells have rotten oranges
        //So we have to determine what is the minimum time required so that all the oranges become rotten.
        //A rotten orange at index[i, j] can rot other fresh orange at indexes[i - 1, j], [i + 1, j], [i, j - 1], [i, j + 1] (up, down, left and right) in unit time.
        //If it is impossible to rot every orange then simply return -1.
        public static int MinimumTimeToRotAll(int[,] matrix)
        {
            int minimumTime = 0;

            // keep track of newly rotten oranges with each pass. skip these
            List<Coordinate> currentRottenOranges = new List<Coordinate>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // if rotten orange found
                    if (matrix[i,j] == 2)
                    {
                        currentRottenOranges.Add(new Coordinate(i, j));
                    }
                }
            }

            while (currentRottenOranges.Count > 0)
            {
                List<Coordinate> newRottenOranges = new List<Coordinate>();
                // on each pass, infect the neighboring oranges
                foreach (var coordinate in currentRottenOranges)
                {
                    newRottenOranges.AddRange(InfectNeighbors(matrix, coordinate.X, coordinate.Y));
                }

                // increment time at completion of one pass
                minimumTime++;

                // check if all oranges are rotten now
                if (AreAllOrangesRotten(matrix))
                {
                    break;
                }
                else if (newRottenOranges.Count == 0) {
                    return -1;
                }
                else {
					// replace current rotten oranges with newly rotten oranges for next pass
					currentRottenOranges = newRottenOranges;    
                }
            }

            return minimumTime >= 0 ? minimumTime : -1;
        }

        private class Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Coordinate (int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        private static bool AreAllOrangesRotten(int[,] matrix)
        {
            bool areAllRotten = true;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					// if fresh orange found
					if (matrix[i, j] == 1)
					{
                        areAllRotten = false;
					}
				}
			}
            return areAllRotten;
        }

        private static List<Coordinate> InfectNeighbors(int[,] matrix, int x, int y)
        {
            List<Coordinate> neighbordingCoordinates = new List<Coordinate> {
                new Coordinate(x-1, y),
                new Coordinate(x+1, y),
                new Coordinate(x, y-1),
                new Coordinate(x, y+1)
            };
            return InfectOranges(matrix, neighbordingCoordinates);
        }

        private static List<Coordinate> InfectOranges(int[,] matrix, List<Coordinate> coordinatesToInfect)
        {
            List<Coordinate> affectedOranges = new List<Coordinate>();
            foreach (var coordinate in coordinatesToInfect)
            {
                // if coordinate is inbounds
                if (coordinate.X >= 0 && coordinate.X < matrix.GetLength(0)
                    && coordinate.Y >= 0 && coordinate.Y < matrix.GetLength(1))
                {
                    // if coordinate is fresh orange, rot it
                    if (matrix[coordinate.X, coordinate.Y] == 1)
                    {
                        matrix[coordinate.X, coordinate.Y] = 2;

                        // add coordinate to affected list
                        affectedOranges.Add(coordinate);
                    }
                }
            }
            return affectedOranges;
        }
	}
}
