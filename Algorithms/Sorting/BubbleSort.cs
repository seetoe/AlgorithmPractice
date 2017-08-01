using System;

public partial class Algorithm {
	//Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list to be sorted,
    //compares each pair of adjacent items and swaps them if they are in the wrong order.
    //The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted. 
    //The algorithm, which is a comparison sort, is named for the way smaller or larger elements "bubble" to the top of the list.
    //Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort.
    //It can be practical if the input is usually in sorted order but may occasionally have some out-of-order elements nearly in position.

	// Average time: n^2
	// Worst time: n^2
	public static void BubbleSort (ref int[] array) {
        bool hasSwap = false;

        // done with bubble sort when pass through list has no swap
        do
        {
            hasSwap = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                // compare each pair of adjacent items
                if (array[i] > array[i + 1])
                {
                    // swap
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                    hasSwap = true;
                }
            }
        } while (hasSwap == true);
    }
}
