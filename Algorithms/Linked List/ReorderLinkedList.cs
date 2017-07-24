using System;
using System.Collections.Generic;

public partial class Algorithm {
    //Given a singly linked list L: L0?L1? ... ?Ln-1?Ln,
    //reorder it to: L0?Ln?L1?Ln-1?L2?Ln-2?...
    
    //For example, given {1,2,3,4}, reorder it to {1,4,2,3}. You must do this in-place without altering the nodes' values.
    public static void ReorderLinkedList (Node rootNode) {
        Node firstSwapNode = rootNode;
        
        while (firstSwapNode.Next != null) {
            Node currentNode = firstSwapNode;
            Node lastNode = null;
            
            // finds the last node and removes it, storing it in lastNode
            while (currentNode.Next != null) {
                if (currentNode.Next.Next == null) {
                    lastNode = currentNode.Next;
                    
                    currentNode.Next = null;
                }
                else {
                    currentNode = currentNode.Next;    
                }
            }
            
            if (firstSwapNode.Next != null && firstSwapNode.Next != lastNode) {
            
                Node temp = firstSwapNode.Next;
                
                firstSwapNode.Next = lastNode;
                lastNode.Next = temp;
                firstSwapNode = temp;    
            }
            else {
                // kinda ugly: adding the last node back to the end after removal
                currentNode.Next = lastNode;
                break;
            }
        }
        
        PrintLinkedList (rootNode);
    }
    
    public static void ReverseLinkedList (Node head) {
        Node previousNode = head;
        Node currentNode = head.Next;
        while (currentNode != null) {
            Node temp = currentNode.Next;
            currentNode.Next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        
        head.Next = null;
    }
	
	public static void MergeLinkedLists (Node firstHead, Node secondHead) {
		Node node1 = firstHead;
		Node node2 = secondHead;
		
		while (node2 != null) {
			Node temp1 = node1.Next;
			Node temp2 = node2.Next;
			
			node1.Next = node2;
			node2.Next = temp1;
			
			node1 = temp1;
			node2 = temp2;
		}
	}
    
    public static void PrintLinkedList(Node startNode) {
        while (startNode.Next != null) {
            Console.Write(startNode.Value + " ");
            startNode = startNode.Next;
        }
        Console.Write(startNode.Value);
        Console.WriteLine();
    }
}

public class Node {
    private int value;
    private Node next;
    
    public Node(int value) {
        this.value = value;
        this.next = null;
    }
    
    public int Value {
      get {
          return this.value;
      }
    }
    
    public Node Next {
        get {
            return this.next;
        }
        set {
            this.next = value;    
        }
    }
}
