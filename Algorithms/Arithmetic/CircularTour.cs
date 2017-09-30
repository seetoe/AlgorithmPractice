using System;
using System.Collections.Generic;

namespace Algorithms.Arithmetic
{
    public class CircularTour
    {
		// n petrol pumps on a circle
		// input:
		// 1. the amount of petrol that every pump has
		// 2. distance from pump to pump
		// output:
		// return integer denoting the first point from where a trunk will be able to complete the circle
		// assume for 1 liter petrol, truck can go 1 unit of distance

		public class PetrolPump
		{
			public int PetrolAmount { get; set; }
			public int DistanceToNextPump { get; set; }

            public PetrolPump(int p, int d)
            {
                this.PetrolAmount = p;
                this.DistanceToNextPump = d;
            }
		}

		public static int FindStartingPoint(int n, List<PetrolPump> pumpData)
		{
			// start truck at a pump with empty tank
			int truckCapacity = 0;

            // variables to keep track
			int startingPoint = 0;
            int currentEndPoint = 1;

            while (startingPoint != currentEndPoint || truckCapacity < 0)
			{
				// pump gas and try to go to the next stop
				truckCapacity += pumpData[startingPoint].PetrolAmount - pumpData[startingPoint].DistanceToNextPump;
				if (truckCapacity < 0)
				{
                    // reset capacity because current starting point is invalid
                    truckCapacity = 0;

                    // try next starting point
                    startingPoint = (startingPoint + 1) % n;

                    // tried all starting points. return -1 for no valid starting points
                    if (startingPoint == 0)
                    {
                        return -1;
                    }
				}

                currentEndPoint = (currentEndPoint + 1) % n;
			}
			return startingPoint;
		}
    }
}
