using System;
using System.Collections.Generic;
using System.Linq;

public partial class Algorithm {
  // Add Two Numbers
   public static LinkedList<int> AddTwoNumbers(LinkedList<int> firstNum, LinkedList<int> secondNum) {
       
       LinkedList<int> solution = new LinkedList<int>();
       
       int maxCount = Math.Max(firstNum.Count, secondNum.Count);
       
       int i = 1;
       
       LinkedListNode<int> firstNumNode = null;
       LinkedListNode<int> secondNumNode = null;
       
       int secondSumDigit = 0;
       
       while (i <= maxCount) {
           
           if (firstNumNode != null) {
               firstNumNode = firstNumNode.Next;
           }
           else {
               firstNumNode = firstNum.First;
           }
           
           if (secondNumNode != null) {
               secondNumNode = secondNumNode.Next;
           }
           else {
               secondNumNode = secondNum.First;
           }
           
           int sum = 0;
           if (firstNumNode != null && secondNumNode != null) {
               sum = firstNumNode.Value + secondNumNode.Value + secondSumDigit;    
           }
           else if (firstNumNode != null && secondNumNode == null) {
               sum = firstNumNode.Value + secondSumDigit;    
           }
           else if (firstNumNode == null && secondNumNode != null) {
               sum = secondNumNode.Value + secondSumDigit;    
           }
           
           int firstSumDigit = sum % 10;
           
          secondSumDigit = (sum / 10) % 10;
           
           solution.AddLast(firstSumDigit);
           
           i++;
       }
       
       return solution;
   }
}

