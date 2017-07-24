using System;
using System.Collections.Generic;

public partial class Algorithm {
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


