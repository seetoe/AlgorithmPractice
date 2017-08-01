using System;

public partial class Algorithm {

	//Insertion sort iterates, consuming one input element each repetition, and growing a sorted output list.
    //At each iteration, insertion sort removes one element from the input data, finds the location it belongs within the sorted list, and inserts it there.
    //It repeats until no input elements remain.
	//Sorting is typically done in-place, by iterating up the array, growing the sorted list behind it.
    //At each array-position, it checks the value there against the largest value in the sorted list (which happens to be next to it, in the previous array-position checked).
    //If larger, it leaves the element in place and moves to the next.
    //If smaller, it finds the correct position within the sorted list, shifts all the larger values up to make a space, and inserts into that correct position.

	// Average time: n^2
	// Worst time: n^2
	public static void InsertionSort (ref int[] array) {
        for (int i = 1; i < array.Length; i++) {
		
            int entry = array[i];
            int j = i;
			
            while (j > 0 && entry < array[j-1]) {
                array[j] = array[--j];
            }
			
            array[j] = entry;
        
        }
    }
}
