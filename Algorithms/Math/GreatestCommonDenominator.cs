using System;

public partial class Algorithm
{
	//		Given 2 non negative integers m and n, find gcd(m, n)

	//GCD of 2 integers m and n is defined as the greatest integer g such that g is a divisor of both m and n.
	//Both m and n fit in a 32 bit signed integer.
    public static int GreatestCommonDenominator(int m, int n)
    {
        int lowerNumber = m > n ? n : m;
        for (int i = lowerNumber; i > 0; i--) {
            // if common divisor of m and n
            if (m % i == 0 && n % i == 0) {
                return i;
            }
        }
        return 1;
    }
}