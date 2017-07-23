using System;
using System.Collections.Generic;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionRemoveDuplicates {
  //static void Main(string[] args) {
      
  //    LinkedList<int> list1 = new LinkedList<int>();
  //    list1.AddLast(1);
  //    list1.AddLast(1);
  //    list1.AddLast(2);
      
  //    LinkedList<int> list2 = new LinkedList<int>();
  //    list2.AddLast(1);
  //    list2.AddLast(1);
  //    list2.AddLast(2);
  //    list2.AddLast(3);
  //    list2.AddLast(3);
  //    list2.AddLast(3);
      
  //    RemoveDups (list1);
      
  //    RemoveDups (list2);
      
  //      foreach (int i in list1) {
  //          Console.Write(i + "->");
  //      }
      
  //    Console.WriteLine();
      
  //      foreach (int i in list2) {
  //          Console.Write(i + "->");
  //      }
      
  //}
    
  // Remove Duplicates from Sorted LinkedList
   static void RemoveDups(LinkedList<int> sortedList) {
       
       LinkedListNode<int> currentNode = sortedList.First;
       
       int currentValue = 0;
           
       while (currentNode.Next != null) {
           
           int nextValue = currentNode.Next.Value;
           
           currentValue = currentNode.Value;
           
           if (currentValue == nextValue) {
               sortedList.Remove(currentNode.Next);
           }
           else {
               currentNode = currentNode.Next;    
           }
       }
   }
}

