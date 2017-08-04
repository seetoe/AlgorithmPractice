﻿using System;
using System.Collections.Generic;

public partial class Algorithm {
	// parent node is processed before its children
	public static string PreorderTraversal (BinaryTreeNode<string> root) {
        string traversalString = "";
		Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
		BinaryTreeNode<string> currentNode = root;
		while (nodesToVisit.Count > 0 || currentNode != null) {
			if (currentNode != null) {
				// visit node
				if (String.IsNullOrEmpty(traversalString))
				{
					traversalString += currentNode.Value;
				}
				else
				{
					traversalString += " " + currentNode.Value;
				}

				 nodesToVisit.Push(currentNode.Right);
				 currentNode = currentNode.Left;    
			}
			else {
			    currentNode = nodesToVisit.Pop();  
			} 
		}
        return traversalString;
  }

	// parent node, then left subtree recursive, then right subtree recursive
    public static void PreorderTraversalRecursive (BinaryTreeNode<string> root, ref string traversalString) {
        if (root != null) {
            // visit node
            if (String.IsNullOrEmpty(traversalString)) {
				traversalString += root.Value; 
            }
            else {
                traversalString += " " + root.Value;
            }

            PreorderTraversalRecursive(root.Left, ref traversalString);
            PreorderTraversalRecursive(root.Right, ref traversalString);
        }
    }
}