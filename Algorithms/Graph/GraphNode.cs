using System;
using System.Collections.Generic;

namespace Algorithms.Graph
{
	public class GraphNode
	{
		private int label;
		private List<GraphNode> neighbors = new List<GraphNode>();

		// constructor
		public GraphNode(int label)
		{
			this.label = label;
			//this.neighbors = neighbors;
		}

		public List<GraphNode> Neighbors
		{
			get
			{
				return this.neighbors;
			}
		}

		public int Label
		{
			get
			{
				return this.label;
			}
		}
	}
}
