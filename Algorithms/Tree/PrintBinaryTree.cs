using System;
using System.Collections.Generic;
using Node = SolutionPrintBinaryTree.Node;

// To execute C#, please define "static void Main" on a class
// named Solution.

class SolutionPrintBinaryTree {
  //static void Main(string[] args) {
  //  Node nodeF = new Node("F", null, null);
  //  Node nodeE = new Node("E", null, null);
  //  Node nodeD = new Node("D", null, null);
  //  Node nodeC = new Node("C", nodeE, nodeF);
  //  Node nodeB = new Node("B", nodeD, null);
  //  Node nodeA = new Node("A", nodeB, nodeC);
  //  Print(nodeA);
  //}

  // print out binary tree in level-by-level representation
  public static void Print(Node root) {
    // breadth first traversal
    Queue<Node> nodesToVisit = new Queue<Node>();
    nodesToVisit.Enqueue(root);
    while (nodesToVisit.Count > 0) {
      int nodesInLevel = nodesToVisit.Count;
      for (int i = 0; i < nodesInLevel; i++) {
          Node currentNode = nodesToVisit.Dequeue();
          Console.Write(currentNode.value + " ");
          if (currentNode.left != null) {
              nodesToVisit.Enqueue(currentNode.left);    
          }
          if (currentNode.right != null) {
              nodesToVisit.Enqueue(currentNode.right);
          }    
      }
      Console.WriteLine();
    }
  }

	// binary tree node
	public class Node
	{
		public string value;
		public Node left;
		public Node right;

		public Node(string value, Node left, Node right)
		{
			this.value = value;
			this.left = left;
			this.right = right;
		}
	}
}


