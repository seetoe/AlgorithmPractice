using System;
namespace Algorithms.Tree
{
    public class AreTreesIdentical
    {
        // given two binary trees, find if both of them are identical or not
        public static bool AreIdentical(BinaryTreeNode<int> root1, BinaryTreeNode<int> root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
            if (root1 != root2)
            {
                return false;
            }
            return AreIdentical(root1.Left, root2.Left) && AreIdentical(root1.Right, root2.Right);
        }
    }
}
