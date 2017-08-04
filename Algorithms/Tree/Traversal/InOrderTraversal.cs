using System;
using System.Collections.Generic;

public partial class Algorithm {
	// left subtree, then parent node, then right subtree
	public static string InorderTraversal (BinaryTreeNode<string> root) {
		string traversalString = "";
        Stack<BinaryTreeNode<string>> nodesToVisit = new Stack<BinaryTreeNode<string>> ();
        BinaryTreeNode<string> currentNode = root;
         
          while (nodesToVisit.Count > 0 || currentNode != null) {
              if (currentNode != null) {
                  nodesToVisit.Push(currentNode);    
                  currentNode = currentNode.Left;
              }
             else {
                 currentNode = nodesToVisit.Pop(); 

                // visit node
				if (String.IsNullOrEmpty(traversalString))
				{
					traversalString += currentNode.Value;
				}
				else
				{
					traversalString += " " + currentNode.Value;
				}

                  currentNode = currentNode.Right;
             }
          }
        return traversalString;
    }

	// left subtree recursive, then parent node, then right subtree recursive
	public static void InorderTraversalRecursive (BinaryTreeNode<string> root, ref string traversalString) {
        if (root != null) {
            InorderTraversalRecursive (root.Left, ref traversalString);

            // visit node
			if (String.IsNullOrEmpty(traversalString))
			{
				traversalString += root.Value;
			}
			else
			{
				traversalString += " " + root.Value;
			}

            InorderTraversalRecursive (root.Right, ref traversalString);
        }
    }
}