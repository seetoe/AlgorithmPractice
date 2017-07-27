using System;
using System.Collections.Generic;

public partial class Algorithm {
	//N light bulbs are connected by a wire.
    //Each bulb has a switch associated with it, however due to faulty wiring, a switch also changes the state of all the bulbs to the right of current bulb.
    //Given an initial state of all bulbs, find the minimum number of switches you have to press to turn on all the bulbs. You can press the same switch multiple times.

	//Note : 0 represents the bulb is off and 1 represents the bulb is on.

	//Example:

	//Input : [0 1 0 1]
	//Return : 4

	//Explanation :

	//press switch 0 : [1 0 1 0]
	//press switch 1 : [1 1 0 1]
	//press switch 2 : [1 1 1 0]
	//press switch 3 : [1 1 1 1]

	public static int LightBulbSwitch(List<int> A)
	{
        int count = 0;
        // flip switches from left to right
        for (int i = 0; i < A.Count; i++) {
            // if current bulb is off
            if (A[i] == 0) {
                //turn on current bulb
                A[i] = 1;
                count++;

                // flip the bulbs to the right of current bulb
                for (int j = i + 1; j < A.Count; j++) {
                    A[j] ^= 1;
                }
            }
        }
        return count;
	}
}
