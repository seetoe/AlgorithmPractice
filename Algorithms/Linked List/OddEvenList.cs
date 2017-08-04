using System;
using System.Collections.Generic;
using System.Linq;

public partial class Algorithm {
	//Given a singly linked list, group all odd nodes together followed by the even nodes.Please note here we are talking about the node number and not the value in the nodes.

	//The program should run in O(1) space complexity and O(nodes) time complexity.

	//Example:
	//Given 1->2->3->4->5->NULL,
	//return 1->3->5->2->4->NULL.

  // Add Two Numbers
   public static LinkedListNode OddEvenList(LinkedListNode head) {
        if (head == null) {
            return null;
        }

        // observation: each pointer will be updated to skip a node, starting from the first node
        LinkedListNode currentNode = head;
        LinkedListNode nextNode = head.Next;

        LinkedListNode connectingNode = nextNode;

        while (currentNode != null && nextNode != null) {
            if (nextNode.Next != null)
            {
                currentNode.Next = nextNode.Next;
                currentNode = currentNode.Next;
                nextNode.Next = currentNode.Next;
                nextNode = nextNode.Next;
            }
        }

        currentNode.Next = connectingNode;

        return head;
   }
}

