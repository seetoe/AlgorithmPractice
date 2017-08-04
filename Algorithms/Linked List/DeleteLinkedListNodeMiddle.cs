using System;

public partial class Algorithm {
    public static void PrintLinkedList (LinkedListNode startingNode) {
        LinkedListNode currentNode = startingNode;
        while (currentNode != null) {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
    
    // delete a node in the middle of a singly linked list, given only access to that node
    public static void DeleteLinkedListNodeMiddle (LinkedListNode nodeToDelete) {
        
        while (nodeToDelete.Next != null) {
            nodeToDelete.Value = nodeToDelete.Next.Value;
            if (nodeToDelete.Next != null && nodeToDelete.Next.Next == null) {
                nodeToDelete.Next = null;
                break;
            }
            else {
                nodeToDelete = nodeToDelete.Next;    
            }
        }
    }
}


