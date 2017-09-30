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
		}

        public GraphNode(int label, List<GraphNode> neighbors)
		{
			this.label = label;
			this.neighbors = neighbors;
		}

		public List<GraphNode> Neighbors
		{
			get
			{
				return this.neighbors;
			}
            set
            {
                this.neighbors = value;
            }
		}

		public int Label
		{
			get
			{
				return this.label;
			}
            set
            {
                this.label = value;
            }
		}
	}
}
