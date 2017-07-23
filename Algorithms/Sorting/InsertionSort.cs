using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionInsertionSort {
  //static void Main(string[] args) {
  //  int[] testArray = {4, 2, 7, 1, 3, 6};
  //    InsertionSort(ref testArray);
  //    foreach (int i in testArray) {
  //        Console.Write(i);
  //    }
  //}
    
    static void InsertionSort (ref int[] array) {
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
