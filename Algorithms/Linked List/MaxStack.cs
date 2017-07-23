using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution {
  //static void Main(string[] args) {
      
  //  MaxStack ms = new MaxStack();
  //  ms.mPush(3);
  //  ms.mPush(11);
  //  ms.mPop();
  //  ms.mPush(4);
  //  ms.mPush(6);
  //  ms.mPop();
  //  ms.mPush(2);
  //  ms.mPop();
      
  //  Console.WriteLine(ms.GetMax());
  //}

}

public class MaxStack : Stack<int> {
    
    private Stack<int> ogStack = new Stack<int>();
    private Stack<int> maxHolder = new Stack<int>();
    
    public void mPush(int i) {
        ogStack.Push(i);
        if (maxHolder.Count == 0) {
            maxHolder.Push(i);
        }
        else if (i > maxHolder.Peek()) {
            maxHolder.Push(i);
        }
    }
    
    public void mPop() {
        int poppedValue = ogStack.Pop();
        if (maxHolder.Count > 0) {
            if (poppedValue == maxHolder.Peek()) {
                maxHolder.Pop();    
            }
        }
    }
    
    // returns the largest item in the stack
    public int GetMax() {
        return maxHolder.Peek();    
    }
}
