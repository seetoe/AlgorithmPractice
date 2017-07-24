using System;

public partial class Algorithm {    
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
