using System;

public partial class Algorithm {
	//Divide the unsorted list into n sublists, each containing 1 element(a list of 1 element is considered sorted).
	//Repeatedly merge sublists to produce new sorted sublists until there is only 1 sublist remaining.
    //This will be the sorted list.

    // Average time: n log(n)
    // Worst time: n log(n)

	public static int[] MergeSort (int[] array) {
        if (array.Length <= 1) {
            return array;
        }

        int middleIndex = array.Length / 2;
        int[] leftArray = new int[middleIndex];
        int[] rightArray = new int[array.Length - middleIndex];

        Array.Copy(array, leftArray, middleIndex);
        Array.Copy(array, middleIndex, rightArray, 0, rightArray.Length);

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        // merge left and right sublists
        return MergeSortedArrays(leftArray, rightArray);
    }
}
