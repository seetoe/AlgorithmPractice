using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionSelectionSort {
  //static void Main(string[] args) {
  //  int[] testArray = {4, 1, 6, 3, 2};
  //  SelectionSort(ref testArray);
  //  foreach (int i in testArray) {
  //      Console.WriteLine(i);
  //  }
        
  //}
    
   static void SelectionSort(ref int[] array) {
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
