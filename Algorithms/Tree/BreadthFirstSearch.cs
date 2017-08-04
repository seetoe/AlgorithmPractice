using System.Collections.Generic;

public partial class Algorithm
{
    //Trees can also be traversed in level-order, where we visit every node on a level before going to a lower level.
    //This search is referred to as breadth-first search (BFS), as the search tree is broadened as much as possible on each depth before going to the next depth.

    public static bool BreadthFirstSearch(BinaryTreeNode<int> rootNode, int data)
    {
		Queue<BinaryTreeNode<int>> searchQueue = new Queue<BinaryTreeNode<int>>();
        if (rootNode != null)
        {
            searchQueue.Enqueue(rootNode);
        }

		BinaryTreeNode<int> currentNode;
        while (searchQueue.Count != 0)
        {
            currentNode = searchQueue.Dequeue();
            if (currentNode.Value == data)
            {
                return true;
            }
            else
            {
                if (currentNode.Left != null) {
					searchQueue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null) {
					searchQueue.Enqueue(currentNode.Right);
                }
            }
        }

        return false;
    }
}