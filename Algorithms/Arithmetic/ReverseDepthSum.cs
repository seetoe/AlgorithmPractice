using System;
using System.Collections.Generic;

namespace Algorithms.Arithmetic
{
    public class ReverseDepthSum
    {
		/**
		 * Given a nested list of integers, returns the sum of all integers in the list weighted by their reversed depth.
		 * For example, given the list {{1,1},2,{1,1}} the deepest level is 2. Thus the function should return 8 (four 1's with weight 1, one 2 with weight 2)
		 * Given the list {1,{4,{6}}} the function should return 17 (one 1 with weight 3, one 4 with weight 2, and one 6 with weight 1)
		 
		 {1,{4,{6}}}
		 - 1 : isInteger() returns true
		 - {4,{6}} : isList() returns true
		 reverse depth = (max_depth + 1 - actual_depth)
			 1 has reverse depth of 3
			 4 has reverse depth of 2
			 6 has reverse depth of 1
		 so, the reverse depth sum = (1 * 3) + (4 * 2) + (6 * 1) = 17

		 */
		public int CalculateSum(List<NestedInteger> input)
		{
            return 0;
		}

		/**
		 * This is the interface that represents nested lists.
		 * You should not implement it, or speculate about its implementation.
		 */
		public interface NestedInteger
		{
			/** @return true if this NestedInteger holds a single integer, rather than a nested list */
			bool isInteger();

			/** @return the single integer that this NestedInteger holds, if it holds a single integer
			 * Return null if this NestedInteger holds a nested list */
			int getInteger();

			/** @return the nested list that this NestedInteger holds, if it holds a nested list
			 * Return null if this NestedInteger holds a single integer */
			List<NestedInteger> getList();
		}

	}
}
