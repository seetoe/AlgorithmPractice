using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class StringAndArrayTests
    {
        [Fact]
        public void CoverPointsTest()
        {
            //Input : [(0, 0), (1, 1), (1, 2)]
            List<int> xCoordinates = new List<int> { 0, 1, 1 };
            List<int> yCoordinates = new List<int> { 0, 1, 2 };
            int minSteps = Algorithm.CoverPoints(xCoordinates, yCoordinates);
            Assert.Equal(minSteps, 2);

            //Input : [(0, 0), (1, 3), (1, 0)]
			xCoordinates = new List<int> { 0, 1, 1 };
			yCoordinates = new List<int> { 0, 3, 0 };
			minSteps = Algorithm.CoverPoints(xCoordinates, yCoordinates);
			Assert.Equal(minSteps, 6);
        }

        [Fact]
        public void FindSingleNumberTest()
        {
            List<int> testList = new List<int> { 1 };
			int singleNumber = Algorithm.FindSingleNumber(testList);
			Assert.Equal(singleNumber, 1);

			List<int> testList2 = new List<int> { 723, 256, 668, 723, 140, 360, 597, 233, 128, 845, 737, 804, 986, 701, 906, 512, 845, 510, 510, 227, 430, 701, 366, 946, 464, 619, 946, 627, 209, 771, 424, 555, 959, 711, 530, 937, 716, 261, 505, 658, 706, 140, 511, 277, 396, 233, 819, 196, 475, 906, 583, 261, 147, 658, 517, 197, 196, 702, 944, 711, 128, 555, 149, 483, 530, 291, 716, 258, 430, 464, 601, 749, 149, 415, 802, 573, 627, 771, 660, 601, 360, 986, 291, 51, 415, 51, 227, 258, 937, 366, 923, 669, 33, 517, 417, 702, 475, 706, 110, 417, 275, 804, 500, 473, 746, 973, 669, 275, 973, 147, 817, 657, 277, 923, 144, 660, 197, 511, 793, 893, 944, 505, 322, 817, 586, 512, 322, 668, 33, 424, 962, 597, 144, 746, 345, 753, 345, 269, 819, 483, 368, 802, 573, 962, 583, 615, 208, 209, 269, 749, 256, 657, 619, 893, 959, 473, 753, 299, 396, 299, 500, 368, 586, 110, 793, 737, 615 };
            int singleNumber2 = Algorithm.FindSingleNumber(testList2);
            Assert.Equal(singleNumber2, 208);
        }

        [Fact]
        public void FourSumTest()
        {
            int[] testArray = {1,0,-1,0,-2, 2, 2};
			int target = 0;
            List<List<int>> result = Algorithm.FourSum(testArray, target);
            Assert.True(result.Count > 0);
		}

        [Fact]
        public void LightBulbSwitch()
        {
            List<int> inputList = new List<int>{ 0, 1, 0, 1 };
            int numberOfSwitches = Algorithm.LightBulbSwitch(inputList);
            Assert.Equal(numberOfSwitches, 4);
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
