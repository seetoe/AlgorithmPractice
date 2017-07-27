using System;
using System.Collections.Generic;

public partial class Algorithm
{
	//Given an even number(greater than 2), return two prime numbers whose sum will be equal to given number.
	//NOTE A solution will always exist.read Goldbach’s conjecture

	//Example:

	//Input : 4
	//Output: 2 + 2 = 4

	//If there is more than one solution possible, return the lexicographically smaller solution.

	//If[a, b] is one solution with a <= b, and[c, d] is another solution with c <= d,
    //then [a, b] < [c, d] if a < c OR a==c AND b<d.

    public static List<int> PrimeSum(int A)
    {
        List<int> solution = new List<int>();
        // prime numbers start at 2
        for (int firstNumber = 2; firstNumber <= (int)Math.Floor((decimal)A/2); firstNumber++) {
            if (IsPrimeNumber(firstNumber)) {
				int secondNumber = A - firstNumber;
                if (IsPrimeNumber(secondNumber)) {
                    solution.AddRange(new[] { firstNumber, secondNumber});
                    return solution;
                }
            }
        }
        return solution;
    }
    private static bool IsPrimeNumber(int num)
    {
        if (num == 0 || num == 1) {
            return false;
        }
        if (num == 2) {
            return true;
        }
        for (int i = 2; i <= (int)Math.Floor(Math.Sqrt(num)); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
} 