using System;

public partial class Algorithm {
    //The algorithm divides the input list into two parts:
    //the sublist of items already sorted, which is built up from left to right at the front(left) of the list, and the sublist of items remaining to be sorted that occupy the rest of the list.
    //Initially, the sorted sublist is empty and the unsorted sublist is the entire input list
    //The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the unsorted sublist,
    //exchanging(swapping) it with the leftmost unsorted element(putting it in sorted order), and moving the sublist boundaries one element to the right.

	// Average time: n^2
	// Worst time: n^2
	public static void SelectionSort(ref int[] array) {
        for (int i = 0; i < array.Length; i++) {
		
            int currentMin = array[i];    
            int currentMinIndex = i;
			
            for (int j = i; j < array.Length; j++) {
                if (array[j] < currentMin) {
                    currentMin = array[j];
                    currentMinIndex = j;
                }
            }
			
            int temp = array[currentMinIndex];
            array[currentMinIndex] = array[i];
            array[i] = temp;
        }
    }
}
