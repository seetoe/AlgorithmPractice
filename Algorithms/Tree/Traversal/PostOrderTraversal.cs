﻿﻿using System;
using System.Collections.Generic;

public partial class Algorithm {
	// parent node is processed after its children
	public static string PostorderTraversal (BinaryTreeNode<string> root) {
		string traversalString = "";
      Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
      BinaryTreeNode<string> currentNode = root;
      BinaryTreeNode<string> lastNodeVisited = null;  
    
      while (nodesToVisit.Count > 0 || currentNode != null) {
        if (currentNode != null) {
             nodesToVisit.Push(currentNode);
            currentNode = currentNode.Left;
        }
         else {
             BinaryTreeNode<string> peekNode = nodesToVisit.Peek();
             if (peekNode.Right != null && peekNode.Right != lastNodeVisited) {
                 currentNode = peekNode.Right;
             }
             else {
				// visit node
				if (String.IsNullOrEmpty(traversalString))
				{
					traversalString += peekNode.Value;
				}
				else
				{
					traversalString += " " + peekNode.Value;
				}

                 lastNodeVisited = nodesToVisit.Pop();
             }
         }
      }
        return traversalString;
    }

	// left subtree recursive, right subtree recursive, then parent node
	public static void PostorderTraversalRecursive (BinaryTreeNode<string> root, ref string traversalString) {
        if (root != null) {
            PostorderTraversalRecursive (root.Left, ref traversalString);
            PostorderTraversalRecursive (root.Right, ref traversalString);

            // visit node
			if (String.IsNullOrEmpty(traversalString))
			{
				traversalString += root.Value;
			}
			else
			{
				traversalString += " " + root.Value;
			}
        }
    }
}