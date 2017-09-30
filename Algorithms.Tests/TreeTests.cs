using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class TreeTests
    {
        [Fact]
        public void PreOrderTraversalTest()
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

            string solution = "F B A D C E G I H";
            string output = "";
			Algorithm.PreorderTraversalRecursive(nodeF, ref output);
            Assert.Equal(solution, output);

			output = Algorithm.PreorderTraversal(nodeF);
			Assert.Equal(solution, output);
		}

		[Fact]
		public void InOrderTraversalTest()
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

            string solution = "A B C D E F G H I";
            string output = "";
			Algorithm.InorderTraversalRecursive(nodeF, ref output);
			Assert.Equal(solution, output);

			output = Algorithm.InorderTraversal(nodeF);
			Assert.Equal(solution, output);
		}

		[Fact]
		public void PostOrderTraversalTest()
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

            string solution = "A C E D B H I G F";
            string output = "";
			Algorithm.PostorderTraversalRecursive(nodeF, ref output);
			Assert.Equal(solution, output);

			output = Algorithm.PostorderTraversal(nodeF);
			Assert.Equal(solution, output);
		}

		[Fact]
		public void BreadthFirstSearchTest()
		{
			BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1, null, null);
			BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2, null, null);
			BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3, node1, null);
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4, null, null);
			BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5, node2, node3);
			BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6, node4, node5);

            Assert.True(Algorithm.BreadthFirstSearch(node6, 1));
		}

        [Fact]
        public void DepthFirstSearchTest()
        {
			BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1, null, null);
			BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2, null, null);
			BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3, node1, null);
			BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4, null, null);
			BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5, node2, node3);
			BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6, node4, node5);

			Assert.True(Algorithm.DepthFirstSearch(node6, 1));
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

        [Fact]
        public void AreTreesIdentical()
        {
			BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
			BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
			BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2, node4);
            BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1, node2, node3);

			BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
			BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5, node6);



            bool areIdentical = Tree.AreTreesIdentical.AreIdentical(node1, node1);
            Assert.True(areIdentical);

			areIdentical = Tree.AreTreesIdentical.AreIdentical(node1, node5);
			Assert.False(areIdentical);
        }
    }
}
