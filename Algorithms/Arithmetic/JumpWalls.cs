using System;
namespace Algorithms.Arithmetic
{
    public class JumpWalls
    {
		// A thief trying to escape from a jail. He has to cross N walls each with varying heights (every height is greater than 0).
		// He climbs X feet every time. But, due to the slippery nature of those walls, every time he slips back by Y feet.
		// Now the task is to calculate the total number of jumps required to cross all walls and escape from the jail.

		// Input: walls and their heights, X, and Y
		// Output: number of jumps

		public static int NumberOfJumps(int[] wallHeights, int x, int y)
		{
			int numberOfJumps = 0;

			foreach (int currentHeight in wallHeights)
			{
				// calculate number of jumps needed for current wall
				int i = currentHeight;
				while (i > 0)
				{
					// first climb of X feet
					i = i - x;
					numberOfJumps++;

					// if first climb is enough to pass current wall, move onto next wall
					if (i <= 0)
					{
                        // 1 jump needed for a wall height that is less than or equal to X
                        continue;
					}
					// else slip back by Y feet
					else
					{
						i = i + y;
					}
				}
			}
			return numberOfJumps;
		}
    }
}
