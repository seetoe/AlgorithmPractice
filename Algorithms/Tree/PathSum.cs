using System;
using System.Collections.Generic;
using System.Linq;

class SolutionPathSum {
  //static void Main(string[] args) {
  //    TreeNode node5 = new TreeNode(5);
  //    TreeNode node4 = new TreeNode(4);
  //    TreeNode node8 = new TreeNode(8);
  //    TreeNode node11 = new TreeNode(11);
  //    TreeNode node7 = new TreeNode(7);
  //    TreeNode node2 = new TreeNode(2);
  //    TreeNode node13 = new TreeNode(13);
  //    TreeNode node4b = new TreeNode(4);
  //    TreeNode node1 = new TreeNode(1);
      
  //    node5.SetChildren (node4, node8);
  //    node4.SetChildren (node11, null);
  //    node11.SetChildren (node7, node2);
  //    node8.SetChildren (node13, node4b);
  //    node4b.SetChildren (null, node1);
      
  //    Console.WriteLine (PathSumRecursive(node5, 22));
  //    Console.WriteLine (PathSumQueue(node5, 22));
  //}

    public static bool PathSumQueue(TreeNode root, int targetSum) {
       Queue<TreeNode> nodesToVisit = new Queue<TreeNode> ();
       Queue<int> nodeSums = new Queue<int> ();
        
       nodesToVisit.Enqueue (root);
       nodeSums.Enqueue(root.Value);
        
       while (nodesToVisit.Count > 0) {
           TreeNode currNode = nodesToVisit.Peek();
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
   public static bool PathSumRecursive (TreeNode root, int targetSum) {
        if (root == null) {
            return false;
        }
       if (root.Value == targetSum && (root.Left == null && root.Right == null)) {
           return true;
       }
        
        return PathSumRecursive(root.Left, targetSum - root.Value) || PathSumRecursive(root.Right, targetSum - root.Value);
   }
    
}

public class TreeNode {
    private int value;
    private TreeNode left;
    private TreeNode right;
    
    public TreeNode(int x) {
        value = x;
    }
    
    public int Value {
        get {
            return this.value;
        }
        set {
            this.value = value;
        }
    }
    
    public TreeNode Left {
        get {
            return this.left;
        }
        set {
            this.left = value;
        }
    }
    
    public TreeNode Right {
        get {
            return this.right;
        }
        set {
            this.right = value;
        }
    }
    
    public void SetChildren(TreeNode ln, TreeNode rn) {
        left = ln;
        right = rn;
    }
}

