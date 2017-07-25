using System;
using System.Collections.Generic;
using System.Linq;

public partial class Algorithm {
    public static bool PathSumQueue(BinaryTreeNode<int> root, int targetSum) {
       Queue<BinaryTreeNode<int>> nodesToVisit = new Queue<BinaryTreeNode<int>> ();
       Queue<int> nodeSums = new Queue<int> ();
        
       nodesToVisit.Enqueue (root);
       nodeSums.Enqueue(root.Value);
        
       while (nodesToVisit.Count > 0) {
           BinaryTreeNode<int> currNode = nodesToVisit.Peek();
           int currentSum = nodeSums.Peek();
           
           if (currentSum == targetSum) {
               return true;
           }
           else {
               if (currNode.Left != null) {
                   nodesToVisit.Enqueue (currNode.Left);
                   nodeSums.Enqueue(currentSum + currNode.Left.Value);    
               }
               if (currNode.Right != null) {
                   nodesToVisit.Enqueue (currNode.Right);
                   nodeSums.Enqueue(currentSum + currNode.Right.Value);    
               }
               
               nodesToVisit.Dequeue();
               nodeSums.Dequeue();
           }
       }
        
       return false;
    }
    
  // Given a binary tree and a sum, determine if the tree has a
  // root to leaf path such that adding up all the values along the
  // paths equals the given sum
   public static bool PathSumRecursive (BinaryTreeNode<int> root, int targetSum) {
        if (root == null) {
            return false;
        }
       if (root.Value == targetSum && (root.Left == null && root.Right == null)) {
           return true;
       }
        
        return PathSumRecursive(root.Left, targetSum - root.Value) || PathSumRecursive(root.Right, targetSum - root.Value);
   }
    
}