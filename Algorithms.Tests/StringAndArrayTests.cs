using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class StringAndArrayTests
    {
        [Fact]
        public void FourSumTest()
        {
            int[] testArray = {1,0,-1,0,-2, 2, 2};
			int target = 0;
            List<List<int>> result = Algorithm.FourSum(testArray, target);
            Assert.True(result.Count > 0);
		}

        [Fact]
        public void LongestPalindromicSubstringTest()
        {
			string testString = "ccd";
            string answerString = "cc";
            Assert.Equal(Algorithm.LongestPalindromicSubstringNaive(testString), answerString);
            Assert.Equal(Algorithm.LongestPalindromicSubstringBetter(testString), answerString);
		}

        [Fact]
        public void MergeSortedArraysTest()
        {
            int[] firstArray = { 1, 4, 5, 9 };
            int[] secondArray = { 1, 2, 7, 8 };
            int[] mergedArray = { 1, 1, 2, 4, 5, 7, 8, 9 };
            Assert.Equal(Algorithm.MergeSortedArrays(firstArray, secondArray), mergedArray);
        }

        [Fact]
        public void MinimumCandiesGivenTest()
        {
            int[] childrenRatings = { 1, 3, 4, 1 };
            int minimumCandies = Algorithm.MinimumCandiesGiven(childrenRatings);
            Assert.Equal(minimumCandies, 7);
		}

		[Fact]
		public void ReverseIntegerTest()
		{
			int testInt = 187265;
            int reversedTestInt = 562781;
			Assert.Equal(Algorithm.ReverseInteger(testInt), reversedTestInt);
		}

        [Fact]
        public void ReverseStringTest()
        {
			string s = "coderpad";
            string sReversed = "dapredoc";
            Assert.Equal(Algorithm.ReverseString(s), sReversed);
		}

        [Fact]
        public void RotateArrayTest()
        {
			int[] inputArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] inputArray2 = { 1, 2, 3, 4, 5, 6, 7 };
			int steps = 3;
            int[] answerArray = { 5, 6, 7, 1, 2, 3, 4 };

			Algorithm.RotateArray(ref inputArray, steps);
            Assert.Equal(inputArray, answerArray);

			Algorithm.RotateArrayInPlace(ref inputArray2, steps);
            Assert.Equal(inputArray2, answerArray);
		}

        [Fact]
        public void SearchInsertPositionTest()
        {
			int[] arr1 = new int[] {1, 3, 5, 6};

			Assert.Equal(Algorithm.SearchInsertPosition(arr1, 5), 2);
            Assert.Equal(Algorithm.SearchInsertPosition(arr1, 2), 1);
			Assert.Equal(Algorithm.SearchInsertPosition(arr1, 7), 4);
			Assert.Equal(Algorithm.SearchInsertPosition(arr1, 0), 0);

			Assert.Equal(Algorithm.SearchInsertPositionBinary(arr1, 5, 0, arr1.Length-1), 2);
			Assert.Equal(Algorithm.SearchInsertPositionBinary(arr1, 2, 0, arr1.Length-1), 1);
			Assert.Equal(Algorithm.SearchInsertPositionBinary(arr1, 7, 0, arr1.Length-1), 4);
			Assert.Equal(Algorithm.SearchInsertPositionBinary(arr1, 0, 0, arr1.Length-1), 0);
		}

        [Fact]
        public void ValidParenthesesTest()
        {
			string positiveTest1 = "()";
			string positiveTest2 = "()[]{}";
			string negativeTest1 = "(]";
			string negativeTest2 = "([)]";
            Assert.True(Algorithm.ValidParentheses(positiveTest1));
            Assert.True(Algorithm.ValidParentheses(positiveTest2));
            Assert.False(Algorithm.ValidParentheses(negativeTest1));
            Assert.False(Algorithm.ValidParentheses(negativeTest2));
        }

        [Fact]
        public void WordLadderTest()
        {
			HashSet<string> dict = new HashSet<string>();
			dict.Add("hot");
			dict.Add("dot");
			dict.Add("dog");
			dict.Add("lot");
			dict.Add("log");

			int lengthOfTransformationSequence = Algorithm.WordLadder ("hit", "cog", dict);
            Assert.Equal(lengthOfTransformationSequence, 5);
		}
    }
}
