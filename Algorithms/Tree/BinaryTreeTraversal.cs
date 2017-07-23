using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class BinaryTreeTraversal {
  //static void Main(string[] args) {
  //    BinaryTreeNode nodeH = new BinaryTreeNode("H", null, null);  
  //    BinaryTreeNode nodeI = new BinaryTreeNode("I", nodeH, null);
  //    BinaryTreeNode nodeG = new BinaryTreeNode("G", null, nodeI);
  //    BinaryTreeNode nodeE = new BinaryTreeNode("E", null, null);
  //    BinaryTreeNode nodeC = new BinaryTreeNode("C", null, null);
  //    BinaryTreeNode nodeA = new BinaryTreeNode("A", null, null);  
  //    BinaryTreeNode nodeD = new BinaryTreeNode("D", nodeC, nodeE);
  //    BinaryTreeNode nodeB = new BinaryTreeNode("B", nodeA, nodeD);
  //    BinaryTreeNode nodeF = new BinaryTreeNode("F", nodeB, nodeG);
      
  //    // Pre-order: F, B, A, D, C, E, G, I, H
  //    Console.WriteLine("Pre-order:");
  //    PreorderTraversalRecursive (nodeF);
  //    Console.WriteLine();
  //    PreorderTraversal (nodeF);
  //    Console.WriteLine();
      
  //    // In-order: A, B, C, D, E, F, G, H, I
  //    Console.WriteLine("In-order:");
  //    InorderTraversal (nodeF);
  //    Console.WriteLine();
  //    InorderTraversalRecursive (nodeF);
  //    Console.WriteLine();
      
  //    // Post-order: A, C, E, D, B, H, I, G, F
  //    Console.WriteLine("Post-order:");
  //    PostorderTraversalRecursive (nodeF);
  //    Console.WriteLine();
  //    PostorderTraversal (nodeF);
  //}

  // parent node is processed before its children
  public static void PreorderTraversal (BinaryTreeNode root) {
      Stack<BinaryTreeNode> nodesToVisit = new Stack<BinaryTreeNode> ();
      BinaryTreeNode currentBinaryTreeNode = root;
      while (nodesToVisit.Count > 0 || currentBinaryTreeNode != null) {
          if (currentBinaryTreeNode != null) {
              // visit node
             Console.Write (currentBinaryTreeNode.Value + " ");
             nodesToVisit.Push(currentBinaryTreeNode.Right);
             currentBinaryTreeNode = (currentBinaryTreeNode.Left);    
          }
         else {
           currentBinaryTreeNode = nodesToVisit.Pop();  
         } 
      }
  }

    // left subtree, then parent node, then right subtree
    public static void InorderTraversal (BinaryTreeNode root) {
        Stack<BinaryTreeNode> nodesToVisit = new Stack<BinaryTreeNode> ();
        BinaryTreeNode currentBinaryTreeNode = root;
         
          while (nodesToVisit.Count > 0 || currentBinaryTreeNode != null) {
              if (currentBinaryTreeNode != null) {
                  nodesToVisit.Push(currentBinaryTreeNode);    
                  currentBinaryTreeNode = currentBinaryTreeNode.Left;
              }
             else {
                 currentBinaryTreeNode = nodesToVisit.Pop();                 
                 Console.Write (currentBinaryTreeNode.Value + " ");
                  currentBinaryTreeNode = currentBinaryTreeNode.Right;
             }
          }
    }
    
    // parent node is processed after its children
    public static void PostorderTraversal (BinaryTreeNode root) {
      Stack<BinaryTreeNode> nodesToVisit = new Stack<BinaryTreeNode> ();
      BinaryTreeNode currentBinaryTreeNode = root;
      BinaryTreeNode lastBinaryTreeNodeVisited = null;  
    
      while (nodesToVisit.Count > 0 || currentBinaryTreeNode != null) {
        if (currentBinaryTreeNode != null) {
             nodesToVisit.Push(currentBinaryTreeNode);
            currentBinaryTreeNode = currentBinaryTreeNode.Left;
        }
         else {
             BinaryTreeNode peekBinaryTreeNode = nodesToVisit.Peek();
             if (peekBinaryTreeNode.Right != null && peekBinaryTreeNode.Right != lastBinaryTreeNodeVisited) {
                 currentBinaryTreeNode = peekBinaryTreeNode.Right;
             }
             else {
                 Console.Write (peekBinaryTreeNode.Value + " ");       
                 lastBinaryTreeNodeVisited = nodesToVisit.Pop();
             }
         }
      }
    }
    
        // parent node is processed before its children
    public static void PreorderTraversalRecursive (BinaryTreeNode root) {
        if (root != null) {
            Console.Write(root.Value  + " ");
            PreorderTraversalRecursive(root.Left);
            PreorderTraversalRecursive(root.Right);    
        }
    }
    
    // left subtree, then parent node, then right subtree
    public static void InorderTraversalRecursive (BinaryTreeNode root) {
        if (root != null) {
            InorderTraversalRecursive (root.Left);
            Console.Write(root.Value  + " ");
            InorderTraversalRecursive (root.Right);
        }
    }
    
    // parent node is processed after its children
    public static void PostorderTraversalRecursive (BinaryTreeNode root) {
        if (root != null) {
            PostorderTraversalRecursive (root.Left);
            PostorderTraversalRecursive (root.Right);
            Console.Write(root.Value  + " ");
        }
    }
 
}

public class BinaryTreeNode {
    private string value;
    private BinaryTreeNode left;
    private BinaryTreeNode right;
    
    public BinaryTreeNode (string value, BinaryTreeNode left, BinaryTreeNode right) {
        this.value = value;
        this.left = left;
        this.right = right;
    }
    
    public string Value {
        get {
            return this.value;
        }
    }
    
    public BinaryTreeNode Left {
        get {
            return this.left;
        }
        set {
            this.left = value;
        }
    }
    public BinaryTreeNode Right {
        get {
            return this.right;
        }
        set {
            this.right = value;
        }
    }
}
