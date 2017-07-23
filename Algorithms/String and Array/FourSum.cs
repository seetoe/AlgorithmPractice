using System;
using System.Collections.Generic;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionFourSum {
  //static void Main(string[] args) {
  //      int[] testArray = {1,0,-1,0,-2, 2, 2};
  //    int target = 0;
  //    List<List<int>> result = FourSum(testArray, target);
  //    foreach (List<int> sol in result) {
  //        Console.Write("(");
  //        foreach (int i in sol) {
  //            Console.Write(i + " ");
  //        }
  //        Console.WriteLine(")");
  //    }
  //}
    
    // 4Sum
	// Given an array S of n integers, are there elements a, b, c, d in S such that sum is target
    public static List<List<int>> FourSum(int[] arr, int target) {
        List<List<int>> result = new List<List<int>>();
        
        if (arr.Length >= 4) {
            Array.Sort(arr);
            
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i+1; j < arr.Length; j++) {
                    for (int k = j+1; k < arr.Length; k++) {
                        for (int l = k+1; l < arr.Length; l++) {
                            if (arr[i]+arr[j]+arr[k]+arr[l] == target) {
                                List<int> sol = new List<int>();
                                sol.Add(arr[i]);
                                sol.Add(arr[j]);
                                sol.Add(arr[k]);
                                sol.Add(arr[l]);
                                bool isNewSolution = true;
                                foreach (List<int> li in result) {
                                    if (li.SequenceEqual(sol)) {
                                        isNewSolution = false;
                                        break;
                                    }
                                }
                                if (isNewSolution) {
                                    result.Add(sol);
                                }
                            }
                        }
                    }
                }
            }
        }
        return result;
    }
}
