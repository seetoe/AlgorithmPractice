using System;
using System.Collections.Generic;

public partial class Algorithm {

	//You are in an infinite 2D grid where you can move in any of the 8 directions :

	//(x, y) to
	//(x+1, y), 
	//(x - 1, y), 
	//(x, y+1), 
	//(x, y-1), 
	//(x-1, y-1), 
	//(x+1,y+1), 
	//(x-1,y+1), 
	//(x+1,y-1) 
	//You are given a sequence of points and the order in which you need to cover the points.
    //Give the minimum number of steps in which you can achieve it.You start from the first point.

    // A represents the x coordinate and B represents the y coordinate

	//Example :

	//Input : [(0, 0), (1, 1), (1, 2)]
	//Output : 2
	//It takes 1 step to move from (0, 0) to(1, 1). It takes one more step to move from(1, 1) to(1, 2).

	public static int CoverPoints(List<int> A, List<int> B)
	{
        int minimumNumberOfSteps = 0;

        // observation: with 1 step, can travel a difference of 1 on x coordinate AND y coordinate

        // if number of x coordinates does not match number of y coordinates
        if (A.Count != B.Count) {
            return 0;
        }

        for (int i = 0; i < A.Count-1; i++) {
            int xDistance = Math.Abs(A[i] - A[i + 1]);
            int yDistance = Math.Abs(B[i] - B[i + 1]);

            // take the greater number of steps required to the next coordinate in the sequence
            minimumNumberOfSteps += xDistance > yDistance ? xDistance : yDistance;
        }

        return minimumNumberOfSteps;
	}
}
