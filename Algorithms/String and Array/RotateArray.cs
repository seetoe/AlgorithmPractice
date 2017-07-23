using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionRotateArray {
  //static void Main(string[] args) {
  //    int[] testArray = {1,2,3,4,5,6,7};
  //   int steps = 3;
      
  //   //RotateArray(ref testArray, steps);
  //    RotateArrayInPlace <int> (ref testArray, steps);
      
  //    foreach (int i in testArray) {
  //        Console.WriteLine (i);
  //    }
  //}
    
   // rotate an array of n elements to the right by k steps by using new array
    public static void RotateArray(ref int[] array, int k) {
        int[] result = new int[array.Length];
        int ii = k;
        for (int i = 0; i <= k; i++) {
            result[ii] = array[i];
            ii++;
        }
        ii = 0;
        for (int i = k+1; i < array.Length; i++) {
            result[ii] = array[i];
            ii++;
        }
        Array.Copy (result, array, array.Length);
    }
    
    // rotate an array of n elements to the right by k steps in place
    public static void RotateArrayInPlace<T> (ref T[] array, int k) {
        for (int i = 0; i <= k; i++) {
            for (int j = 0; j < array.Length-1; j++) {
                Swap<T> (ref array, j, j+1);
            }
        }
    }
    
    public static void Swap<T> (ref T[] array, int index1, int index2) {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
