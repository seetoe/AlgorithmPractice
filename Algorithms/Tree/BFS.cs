using System.Collections.Generic;

public class BreadthFirstSearch
{
	public class BinaryTreeNode
	{
		public BinaryTreeNode Left { get; set; }

		public BinaryTreeNode Right { get; set; }

		public int Data { get; set; }
	}

	private Queue<BinaryTreeNode> _searchQueue;
	private BinaryTreeNode _root;

	public BreadthFirstSearch(BinaryTreeNode rootNode)
	{
		_searchQueue = new Queue<BinaryTreeNode>();
		_root = rootNode;
	}

	public bool Search(int data)
	{
		BinaryTreeNode _current = _root;
		_searchQueue.Enqueue(_root);

		while (_searchQueue.Count != 0)
		{
			_current = _searchQueue.Dequeue();
			if (_current.Data == data)
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