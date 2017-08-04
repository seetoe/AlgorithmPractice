using System;

public partial class Algorithm {
    public static bool IsPalindromeString (string s) {
        bool result = true;
        int i = 0;
        int j = s.Length-1;
        while (i <= j) {            
            if (char.IsWhiteSpace(s[i])) {
                i++;
                continue;
            }
            if (char.IsWhiteSpace(s[j])) {
                j--;
                continue;
            }
            if (s[i] != s[j]) {
                result = false;
                break;
            }
            i++;
            j--;
        }
        return result;
    }
}
