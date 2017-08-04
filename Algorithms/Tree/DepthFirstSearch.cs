using System.Collections.Generic;

public partial class Algorithm
{
	//These searches are referred to as depth-first search(DFS), as the search tree is deepened as much as possible on each child before going to the next sibling.
    //For a binary tree, they are defined as display operations recursively at each node, starting with the root, whose algorithm is as follows:
	//The general recursive pattern for traversing a (non-empty) binary tree is this: At node N you must do these three things:
	//(L) Recursively traverse its left subtree.When this step is finished you are back at N again.
	//(R) Recursively traverse its right subtree. When this step is finished you are back at N again.
	//(N) Process N itself.
	//We may do these things in any order.

	public static bool DepthFirstSearch(BinaryTreeNode<int> rootNode, int data)
    {
	    Stack<BinaryTreeNode<int>> searchStack = new Stack<BinaryTreeNode<int>>();
        if (rootNode != null) {
			searchStack.Push(rootNode);
        }

		BinaryTreeNode<int> currentNode;
        while (searchStack.Count != 0)
        {
            currentNode = searchStack.Pop();
            if (currentNode.Value == data)
            {
                return true;
            }
            else
            {
                if (currentNode.Right != null) {
					searchStack.Push(currentNode.Right);
                }
                if (currentNode.Left != null) {
					searchStack.Push(currentNode.Left);
                }
            }
        }

        return false;
    }
}