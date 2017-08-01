using System;

public partial class Algorithm {
	//Quicksort is a divide and conquer algorithm.
    //Quicksort first divides a large array into two smaller sub-arrays: the low elements and the high elements.
    //Quicksort can then recursively sort the sub-arrays.

	//The steps are:

	//Pick an element, called a pivot, from the array.
	//Partitioning: reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it(equal values can go either way).
    //After this partitioning, the pivot is in its final position.This is called the partition operation.
	//Recursively apply the above steps to the sub-array of elements with smaller values and separately to the sub-array of elements with greater values.
	//The base case of the recursion is arrays of size zero or one, which never need to be sorted.

	// Average time: n log(n)
	// Worst time: n^2
	public static void QuickSort(ref int[] array, int start, int end) {
		if (array.Length == 0 || start >= end){
		    return;
		}

        // call a random pivot point
	    Random randomNum = new Random();
	    int pivotIndex = randomNum.Next(start, end);
	    int pivotValue = array[pivotIndex];

	    int leftIndex = start;
	    int rightIndex = end;

		while (leftIndex <= rightIndex) {
			while (array[leftIndex] < pivotValue) {
			    leftIndex++;
			}
			while (array[rightIndex] > pivotValue) {
			    rightIndex--;
			}
			if (leftIndex <= rightIndex) {
				int temp = array[rightIndex];
				array[rightIndex] = array[leftIndex];
				array[leftIndex] = temp;
				leftIndex++;
				rightIndex--;
			}
		}

	    QuickSort(ref array, start, rightIndex);
	    QuickSort(ref array, leftIndex, end);

	}

	static int[] SubArray (int[] array, int startIndex, int endIndex) {
	  int length = (endIndex - startIndex) + 1;
	  int[] result = new int[length];
	  Array.Copy(array, startIndex, result, 0, length);
	  return result;
	}
    
}
