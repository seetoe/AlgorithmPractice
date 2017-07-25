using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class TreeTests
    {
		[Fact]
		public void BinaryTreeTraversalTest()
		{
		    BinaryTreeNode<string> nodeH = new BinaryTreeNode<string>("H", null, null);  
		    BinaryTreeNode<string> nodeI = new BinaryTreeNode<string>("I", nodeH, null);
		    BinaryTreeNode<string> nodeG = new BinaryTreeNode<string>("G", null, nodeI);
		    BinaryTreeNode<string> nodeE = new BinaryTreeNode<string>("E", null, null);
		    BinaryTreeNode<string> nodeC = new BinaryTreeNode<string>("C", null, null);
		    BinaryTreeNode<string> nodeA = new BinaryTreeNode<string>("A", null, null);  
		    BinaryTreeNode<string> nodeD = new BinaryTreeNode<string>("D", nodeC, nodeE);
		    BinaryTreeNode<string> nodeB = new BinaryTreeNode<string>("B", nodeA, nodeD);
		    BinaryTreeNode<string> nodeF = new BinaryTreeNode<string>("F", nodeB, nodeG);

			// Pre-order: F, B, A, D, C, E, G, I, H
			Console.WriteLine("Pre-order:");
			Algorithm.PreorderTraversalRecursive(nodeF);
			Console.WriteLine();
			Algorithm.PreorderTraversal(nodeF);
			Console.WriteLine();

			// In-order: A, B, C, D, E, F, G, H, I
			Console.WriteLine("In-order:");
			Algorithm.InorderTraversal(nodeF);
			Console.WriteLine();
			Algorithm.InorderTraversalRecursive(nodeF);
			Console.WriteLine();

			// Post-order: A, C, E, D, B, H, I, G, F
			Console.WriteLine("Post-order:");
			Algorithm.PostorderTraversalRecursive(nodeF);
			Console.WriteLine();
			Algorithm.PostorderTraversal(nodeF);
		}

		[Fact]
		public void BreadthFirstSearchTest()
		{

		}

        [Fact]
        public void DepthFirstSearchTest()
        {
            
        }

		[Fact]
		public void PathSumTest()
		{
		    BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
		    BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
		    BinaryTreeNode<int> node8 = new BinaryTreeNode<int>(8);
		    BinaryTreeNode<int> node11 = new BinaryTreeNode<int>(11);
		    BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
		    BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
		    BinaryTreeNode<int> node13 = new BinaryTreeNode<int>(13);
		    BinaryTreeNode<int> node4b = new BinaryTreeNode<int>(4);
		    BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1);

		    node5.SetChildren (node4, node8);
		    node4.SetChildren (node11, null);
		    node11.SetChildren (node7, node2);
		    node8.SetChildren (node13, node4b);
		    node4b.SetChildren (null, node1);

            Assert.True(Algorithm.PathSumRecursive(node5, 22));
		    Assert.True(Algorithm.PathSumQueue(node5, 22));
		}

        [Fact]
        public void PrintBinaryTreeTest()
        {
			BinaryTreeNode<string> nodeF = new BinaryTreeNode<string>("F", null, null);
			BinaryTreeNode<string> nodeE = new BinaryTreeNode<string>("E", null, null);
			BinaryTreeNode<string> nodeD = new BinaryTreeNode<string>("D", null, null);
			BinaryTreeNode<string> nodeC = new BinaryTreeNode<string>("C", nodeE, nodeF);
			BinaryTreeNode<string> nodeB = new BinaryTreeNode<string>("B", nodeD, null);
			BinaryTreeNode<string> nodeA = new BinaryTreeNode<string>("A", nodeB, nodeC);
            Algorithm.PrintBinaryTree(nodeA);
		}
    }
}
