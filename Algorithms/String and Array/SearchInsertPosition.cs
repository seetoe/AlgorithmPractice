using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionSearchInsertPosition {
  //static void Main(string[] args) {
  //  int[] arr1 = new int[] {1, 3, 5, 6};
      
  //  Console.WriteLine(SearchInsertPosition(arr1, 5));
  //  Console.WriteLine(SearchInsertPosition(arr1, 2));
  //  Console.WriteLine(SearchInsertPosition(arr1, 7));
  //  Console.WriteLine(SearchInsertPosition(arr1, 0));
      
  //  Console.WriteLine(SearchInsertPositionBinary(arr1, 5, 0, arr1.Length-1));
  //  Console.WriteLine(SearchInsertPositionBinary(arr1, 2, 0, arr1.Length-1));
  //  Console.WriteLine(SearchInsertPositionBinary(arr1, 7, 0, arr1.Length-1));
  //  Console.WriteLine(SearchInsertPositionBinary(arr1, 0, 0, arr1.Length-1));
  //}

    // given a sorted array and a target value,
    // return the index if the target is found
    // if not, return the index where it would be if it were inserted
    public static int SearchInsertPosition(int[] arr, int target) {
        int i = 0;
        while (i < arr.Length && arr[i] <= target) {
            if (arr[i] == target) {
                return i;
            }
            i++;
        }
        return i;
    }
    
    public static int SearchInsertPositionBinary(int[] arr, int target, int start, int end) {
        int midpoint = (int)Math.Floor((decimal)(start+end)/2);

        if (target < arr[midpoint]) {
            if (midpoint == 0) {
                return midpoint;
            }
            return SearchInsertPositionBinary (arr, target, start, midpoint-1);    
        }
        else if (arr[midpoint] < target) {
            if (midpoint == end) {
                return midpoint+1;
            }
            return SearchInsertPositionBinary (arr, target, midpoint+1, end);             
        }
        else {
            return midpoint;
        }
    }
}


