using System.Collections.Generic;

public partial class Algorithm
{
    public class DepthFirstSearch
    {
        private Stack<BinaryTreeNode<int>> _searchStack;
        private BinaryTreeNode<int> _root;

        public DepthFirstSearch(BinaryTreeNode<int> rootNode)
        {
            _root = rootNode;
            _searchStack = new Stack<BinaryTreeNode<int>>();
        }

        public bool Search(int data)
        {
            BinaryTreeNode<int> _current;
            _searchStack.Push(_root);

            while (_searchStack.Count != 0)
            {
                _current = _searchStack.Pop();
                if (_current.Value == data)
                {
                    return true;
                }
                else
                {
                    _searchStack.Push(_current.Right);
                    _searchStack.Push(_current.Left);
                }
            }

            return false;
        }
    }
}