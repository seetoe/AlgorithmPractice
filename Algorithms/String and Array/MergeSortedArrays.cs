using System;
using System.Collections.Generic;

public partial class Algorithm {    
    // merge two sorted arrays into one sorted array
    public static int[] MergeSortedArrays (int[] a1, int[] a2) {
        //int[] resultArray = new int[a1.Length + a2.Length];
        List<int> resultArray = new List<int> ();
        int i = 0;
        int j = 0;
        while (i < a1.Length || j < a2.Length) {
		
            if (i < a1.Length && j < a2.Length) {
                if (a1[i] <= a2[j]) {
                    resultArray.Add(a1[i]);
                    i++;
                }
                else {
                    resultArray.Add(a2[j]);
                    j++;
                }
            }
            else if (i < a1.Length) {
                resultArray.Add(a1[i]);
                i++;
            }
            else {
                resultArray.Add(a2[j]);
                j++;
            }
            
        }
        return resultArray.ToArray();
    }
}
