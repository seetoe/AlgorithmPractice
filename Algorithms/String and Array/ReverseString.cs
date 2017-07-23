using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionReverseString {
  //static void Main(string[] args) {
  //  string s = "coderpad";
  //  Console.WriteLine(ReverseString(s));
  //}

    public static string ReverseString(string s) {
        char[] sArray = s.ToCharArray();
        for (int i = 0, j = s.Length -1; i < s.Length; i++, j--) {
            if (i < j) {
                char temp = sArray[i];
                sArray[i] = sArray[j];
                sArray[j] = temp;    
            }
        }
        return new string(sArray);
    }
}


