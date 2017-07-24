using System;
using System.Collections.Generic;

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
