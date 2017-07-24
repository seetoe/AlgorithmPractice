using System;
using System.Collections.Generic;
using System.Linq;

public partial class Algorithm {    
    // Remove Duplicates from Sorted LinkedList
    public static void RemoveDuplicates(LinkedList<int> sortedList) {
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

    public static bool ContainsDuplicatesLinkedList(LinkedList<int> sortedList) {
        LinkedListNode<int> currentNode = sortedList.First;

        while (currentNode.Next != null) {
            int currentValue = currentNode.Value;
            int nextValue = currentNode.Next.Value;

            if (currentValue == nextValue) {
                return true;
            }
        }

        return false;
    }
}

