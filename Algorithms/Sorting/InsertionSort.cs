using System;

public partial class Algorithm {
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
