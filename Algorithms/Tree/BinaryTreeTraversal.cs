using System;
using System.Collections.Generic;

public partial class Algorithm {
  // parent node is processed before its children
  public static void PreorderTraversal (BinaryTreeNode<string> root) {
      Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
      BinaryTreeNode<string> currentBinaryTreeNode = root;
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
    public static void InorderTraversal (BinaryTreeNode<string> root) {
        Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
        BinaryTreeNode<string> currentBinaryTreeNode = root;
         
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
    public static void PostorderTraversal (BinaryTreeNode<string> root) {
      Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
      BinaryTreeNode<string> currentBinaryTreeNode = root;
      BinaryTreeNode<string> lastBinaryTreeNodeVisited = null;  
    
      while (nodesToVisit.Count > 0 || currentBinaryTreeNode != null) {
        if (currentBinaryTreeNode != null) {
             nodesToVisit.Push(currentBinaryTreeNode);
            currentBinaryTreeNode = currentBinaryTreeNode.Left;
        }
         else {
             BinaryTreeNode<string> peekBinaryTreeNode = nodesToVisit.Peek();
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
    public static void PreorderTraversalRecursive (BinaryTreeNode<string> root) {
        if (root != null) {
            Console.Write(root.Value  + " ");
            PreorderTraversalRecursive(root.Left);
            PreorderTraversalRecursive(root.Right);    
        }
    }
    
    // left subtree, then parent node, then right subtree
    public static void InorderTraversalRecursive (BinaryTreeNode<string> root) {
        if (root != null) {
            InorderTraversalRecursive (root.Left);
            Console.Write(root.Value  + " ");
            InorderTraversalRecursive (root.Right);
        }
    }
    
    // parent node is processed after its children
    public static void PostorderTraversalRecursive (BinaryTreeNode<string> root) {
        if (root != null) {
            PostorderTraversalRecursive (root.Left);
            PostorderTraversalRecursive (root.Right);
            Console.Write(root.Value  + " ");
        }
    }
 
}