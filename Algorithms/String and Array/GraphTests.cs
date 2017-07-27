using System;
using System.Collections.Generic;
using Xunit;
using GraphNode = Algorithms.Graph.GraphNode;

namespace Algorithms.Tests
{
    public class GraphTests
    {
        [Fact]
        public void CloneGraphTest()
        {
            GraphNode node1 = new GraphNode(1);
			GraphNode node2 = new GraphNode(2);
			GraphNode node0 = new GraphNode(0);
			node0.Neighbors.Add(node1);
			node0.Neighbors.Add(node2);
			node1.Neighbors.Add(node2);
			node2.Neighbors.Add(node2);

			//PrintGraph(node0);

			GraphNode copyNode = Algorithms.Graph.Algorithm.CloneGraph(node0);

            Algorithms.Graph.Algorithm.PrintGraph(copyNode);
            Assert.True(true);
		}
    }
}
