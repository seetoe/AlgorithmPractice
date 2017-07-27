using System;
using System.Collections.Generic;

public partial class Algorithm {
	public static int FindSingleNumber(List<int> A)
	{
		A.Sort();
        int numberToWatch = A[0];
		int seenCounter = 0;
		foreach (int num in A)
		{
			if (seenCounter == 0)
			{
				// set current number to watch
				numberToWatch = num;
				seenCounter = 1;
			}
			else if (seenCounter == 1)
			{
				if (num != numberToWatch)
				{
                    return numberToWatch;
				}
				else
				{
					// reset seen counter
					seenCounter = 0;
				}
			}
		}
		return numberToWatch;
	}
}
