using System;
using System.Collections.Generic;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

public class SolutionAddTwoNumbers {
  //static void Main(string[] args) {
  //      LinkedList<int> num1 = new LinkedList<int>();
  //    num1.AddLast(2);
  //    num1.AddLast(4);
  //    num1.AddLast(3);
  //    num1.AddLast(2);
	  
  //    LinkedList<int> num2 = new LinkedList<int>();
  //    num2.AddLast(5);
  //    num2.AddLast(6);
  //    num2.AddLast(4);
      
  //      LinkedList<int> solution = AddTwoNumbers(num1, num2);
  //      foreach (int i in solution) {
  //          Console.WriteLine(i);
  //      }
  //}
    
  // Add Two Numbers
   static LinkedList<int> AddTwoNumbers(LinkedList<int> firstNum, LinkedList<int> secondNum) {
       
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

