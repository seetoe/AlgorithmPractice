using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionValidParentheses {
  //static void Main(string[] args) {
  //  string positiveTest1 = "()";
  //  string positiveTest2 = "()[]{}";
  //  string negativeTest1 = "(]";
  //  string negativeTest2 = "([)]";
  //  Console.WriteLine(ValidParentheses(positiveTest1));
  //  Console.WriteLine(ValidParentheses(positiveTest2));
  //  Console.WriteLine(ValidParentheses(negativeTest1));
  //  Console.WriteLine(ValidParentheses(negativeTest2));
  //}
    
    // Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    // The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    public static bool ValidParentheses(string s) {
        bool valid = true;
        
        // keys are opening brackets, values are closing brackets
        Dictionary<char, char> brackets = new Dictionary<char, char>();
        brackets.Add('(', ')');
        brackets.Add('{', '}');
        brackets.Add('[', ']');
        
        Stack<char> pendingClosingBracket = new Stack<char> ();
        
        char[] sArray = s.ToCharArray();
        for (int i = 0; i < sArray.Length; i++) {
            char currentBracket = sArray[i];
            
            // if current bracket is an opening bracket, following brackets can only be any opening bracket or closing bracket for last bracket
            if (brackets.ContainsKey(currentBracket)) {
                char closingBracket = brackets[currentBracket];
                pendingClosingBracket.Push(closingBracket);
            }
            // else current bracket is a closing bracket
            else {
                char lastClosingBracket = pendingClosingBracket.Pop();
                if (currentBracket != lastClosingBracket) {
                    valid = false;
                    break;
                }
            }
        }
        
        if (pendingClosingBracket.Count > 0) {
            return false;
        }
        return valid;
    }
    
    
}
