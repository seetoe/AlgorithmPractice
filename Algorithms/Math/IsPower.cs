using System;

public partial class Algorithm
{
	//Given a positive integer which fits in a 32 bit signed integer, find if it can be expressed as A^P where P > 1 and A > 0. A and P both should be integers.

	//Example

	//Input : 4
	//Output : True  
	//as 2^2 = 4.

    public static bool IsPower(int A)
    {
        // for 32 bit signed integer, max is 2^31
        for (double e = 2; e < 32; e++) {
            for (double b = 1; b < Math.Sqrt(A); b++) {
				if (Math.Pow(b, e) == Convert.ToDouble(A))
				{
                    return true;
				}    
            }
        }
        return false;
    }
} 