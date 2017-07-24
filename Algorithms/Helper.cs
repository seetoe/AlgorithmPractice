using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Helper
    {
		public static string LinkedListToString(Node startNode)
		{
			string output = "";
			while (startNode.Next != null)
			{
				output += (startNode.Value + " ");
				startNode = startNode.Next;
			}
			output += startNode.Value;
			return output;
		}
    }
}
