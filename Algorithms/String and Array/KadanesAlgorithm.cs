using System;
namespace Algorithms.StringandArray
{
    public class KadanesAlgorithm
    {
        public KadanesAlgorithm()
        {
        }

        public static int MaxSumOfContiguousSubArray(int[] arr, int size)
        {
            int currentSum = arr[0];
            int currentMax = arr[0];
            for (int i = 1; i < size; i++)
            {
                currentSum += arr[i];
                currentMax = System.Math.Max(currentMax, currentSum);
            }
            return currentMax;
        }
    }
}
