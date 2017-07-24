using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class SortingTests
    {
        [Fact]
        public void InsertionSortTest()
        {
			int[] inputArray = { 4, 2, 7, 1, 3, 6 };
            int[] solutionArray = { 1, 2, 3, 4, 6, 7 };
			Algorithm.InsertionSort(ref inputArray);
            Assert.Equal(inputArray, solutionArray);
		}

        [Fact]
        public void QuickSortTest()
        {
			int[] inputArray = { 1, 2, 6, 3, 9, 11, 10 };
            int[] solutionArray = { 1, 2, 3, 6, 9, 10, 11 };
			Algorithm.QuickSort(ref inputArray, 0, 6);
            Assert.Equal(inputArray, solutionArray);
		}

        [Fact]
        public void SelectionSortTest()
        {
			int[] inputArray = { 4, 1, 6, 3, 2 };
            int[] solutionArray = { 1, 2, 3, 4, 6 };
			Algorithm.SelectionSort(ref inputArray);
            Assert.Equal(inputArray, solutionArray);
		}
    }
}
