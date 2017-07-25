using System;
using System.Collections.Generic;

public partial class Algorithm {
  // print out binary tree in level-by-level representation
  public static void PrintBinaryTree(BinaryTreeNode<string> root) {
    // breadth first traversal
    Queue<BinaryTreeNode<string>> nodesToVisit = new Queue<BinaryTreeNode<string>>();
    nodesToVisit.Enqueue(root);
    while (nodesToVisit.Count > 0) {
      int nodesInLevel = nodesToVisit.Count;
      for (int i = 0; i < nodesInLevel; i++) {
          BinaryTreeNode<string> currentNode = nodesToVisit.Dequeue();
          Console.Write(currentNode.Value + " ");
          if (currentNode.Left != null) {
              nodesToVisit.Enqueue(currentNode.Left);    
          }
          if (currentNode.Right != null) {
              nodesToVisit.Enqueue(currentNode.Right);
          }    
      }
      Console.WriteLine();
    }
  }
}


