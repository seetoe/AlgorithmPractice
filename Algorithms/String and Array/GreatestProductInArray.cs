using System;
namespace Algorithms.StringandArray
{
    public class GreatestProductInArray
    {
		// Given an array of n elements,
        // find the greatest number such that it is a product of two elements of given array
        // If no such element exists, print -1. 
		public static int GreatestProduct(int[] arr)
        {
            int result = -1;
            int currentProduct = -1;

            // sort array first
            Array.Sort<int>(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                currentProduct = arr[i];
                if (IsProductOfArrayElementPair(currentProduct, arr))
                {
                    result = Math.Max(currentProduct, result);
                }
            }
            return result;
        }

        // helper method
        private static bool IsProductOfArrayElementPair(int product, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // if product is multiple of current element
                int currentElement = arr[i];
                if (product % currentElement == 0)
                {
                    int correspondingElement = product / currentElement;
                    if (Array.IndexOf(arr, correspondingElement) > -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
