using System;
using System.Collections.Generic;
using System.Linq;

public partial class Algorithm {
   //Given a singly linked list, determine if it is a palindrome.
   public static bool IsPalindromeLinkedList(LinkedListNode head) {
        // reverse the linked list then compare the two lists
        LinkedListNode end = ReverseLinkedList(head);

        while (head != null && end != null) {
            if (head.Value != end.Value) {
                return false;
            }
            head = head.Next;
            end = end.Next;
        }
        return true;
   }

    public static LinkedListNode ReverseLinkedList(LinkedListNode head) {
        LinkedListNode currentNode = head;
        LinkedListNode nextNode = head.Next;
        while (nextNode != null) {
            LinkedListNode temp = nextNode.Next;
            nextNode.Next = currentNode;

            currentNode = nextNode;
            nextNode = temp;
        }

        // set original head of list to be end of list
        head.Next = null;

        // return new head of list
        return currentNode;;
    }
}

