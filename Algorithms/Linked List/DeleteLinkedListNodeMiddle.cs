using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

public class SolutionDeleteLinkedListNodeMiddle {
  //static void Main(string[] args) {
      
  //    Node node5 = new Node (5, null);
  //    Node node4 = new Node (4, node5);
  //    Node node3 = new Node (3, node4);
  //    Node node2 = new Node (2, node3);
  //  Node node1 = new Node (1, node2);
      
  //    PrintLinkedList (node1);
      
  //  DeleteNode (node5);
      
  //  PrintLinkedList (node1);
  //}
    
    public static void PrintLinkedList (Node startingNode) {
        Node currentNode = startingNode;
        while (currentNode != null) {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
    
// delete a node in the middle of a singly linked list, given only access to that node
    public static void DeleteNode (Node nodeToDelete) {
        
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

	public class Node
	{
		private int value;
		private Node next;

		public Node(int value, Node next)
		{
			this.value = value;
			this.next = next;
		}

		public int Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		public Node Next
		{
			get
			{
				return this.next;
			}
			set
			{
				this.next = value;
			}
		}
	}
}


