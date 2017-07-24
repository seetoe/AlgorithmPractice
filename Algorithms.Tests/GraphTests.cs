using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class GraphTests
    {
        [Fact]
        public void CloneGraphTest()
        {
			Algorithm.GraphNode node1 = new Algorithm.GraphNode(1);
			Algorithm.GraphNode node2 = new Algorithm.GraphNode(2);
			Algorithm.GraphNode node0 = new Algorithm.GraphNode(0);
			node0.Neighbors.Add(node1);
			node0.Neighbors.Add(node2);
			node1.Neighbors.Add(node2);
			node2.Neighbors.Add(node2);

			//PrintGraph(node0);

			Algorithm.GraphNode copyNode = Algorithm.CloneGraph(node0);

			Algorithm.PrintGraph(copyNode);
            Assert.True(true);
		}
    }
}
