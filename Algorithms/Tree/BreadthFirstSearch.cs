using System.Collections.Generic;

public class BreadthFirstSearch
{
	private Queue<BinaryTreeNode<int>> _searchQueue;
	private BinaryTreeNode<int> _root;

	public BreadthFirstSearch(BinaryTreeNode<int> rootNode)
	{
		_searchQueue = new Queue<BinaryTreeNode<int>>();
		_root = rootNode;
	}

	public bool Search(int data)
	{
		BinaryTreeNode<int> _current = _root;
		_searchQueue.Enqueue(_root);

		while (_searchQueue.Count != 0)
		{
			_current = _searchQueue.Dequeue();
			if (_current.Value == data)
			{
				return true;
			}
			else
			{
				_searchQueue.Enqueue(_current.Left);
				_searchQueue.Enqueue(_current.Right);
			}
		}

		return false;
	}
}