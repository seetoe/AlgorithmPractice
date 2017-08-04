using System;

public partial class Algorithm {
    // find the longest palindromic substring by checking all substrings
    public static string LongestPalindromicSubstringNaive (string s) {
        int currentMaxLength = 0;
        string currentMaxString = "";
        for (int i = 0; i < s.Length; i++) {
            for (int j = s.Length; j > i ; j--) {
                string currentSubstring = s.Substring(i, j-i);
                //Console.WriteLine ("current substring: " + currentSubstring);
                if (currentSubstring.Length > currentMaxLength) {
                    if (IsPalindromeString(currentSubstring)) {
                        currentMaxLength = currentSubstring.Length;
                        currentMaxString = currentSubstring;
                    }
                }
            }
            
        }
        return currentMaxString;
    }
    
    // goes through longest length substrings first and stops as soon as palindrome is found
    public static string LongestPalindromicSubstringBetter (string s) {
        for (int length = s.Length; length >= 0; length--) {
            for (int startIndex = 0; startIndex < s.Length; startIndex++) {
                if ((startIndex + length) <= (s.Length-1)) {
                    string currentSubstring = s.Substring(startIndex, length);
                    if (IsPalindromeString(currentSubstring)) {
                        return currentSubstring;
                    }    
                }
                else {
                    break;
                }
            }    
        }
        return "";
    }
}
