using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionQuickSort {
  //static void Main(string[] args) {
  //  int[] testArray = {1, 2, 6, 3, 9, 11, 10};
  //    QuickSort(ref testArray, 0, 6);
      
  //    foreach (int i in testArray) {
  //        Console.WriteLine(i);
  //    }
      
  //}

  static void QuickSort(ref int[] array, int start, int end) {
    if (array.Length == 0){
        return;
    }
      if (start >= end) {
          return;
      }
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
