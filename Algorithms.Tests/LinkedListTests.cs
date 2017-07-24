using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void AddTwoNumbersTest()
        {
			LinkedList<int> num1 = new LinkedList<int>();
			num1.AddLast(2);
			num1.AddLast(4);
			num1.AddLast(3);
			num1.AddLast(2);

			LinkedList<int> num2 = new LinkedList<int>();
			num2.AddLast(5);
			num2.AddLast(6);
			num2.AddLast(4);

            LinkedList<int> sum = Algorithm.AddTwoNumbers(num1, num2);
            string stringSum = "";
			foreach (int i in sum) {
                stringSum = i.ToString() + stringSum;
			}

            string stringSolution = "2807";

            Assert.Equal(stringSum, stringSolution);
		}

        [Fact]
        public void DeleteLinkedListNodeMiddleTest()
        {
			Algorithm.LinkedListNode node5 = new Algorithm.LinkedListNode (5, null);
			Algorithm.LinkedListNode node4 = new Algorithm.LinkedListNode (4, node5);
			Algorithm.LinkedListNode node3 = new Algorithm.LinkedListNode (3, node4);
			Algorithm.LinkedListNode node2 = new Algorithm.LinkedListNode (2, node3);
			Algorithm.LinkedListNode node1 = new Algorithm.LinkedListNode (1, node2);

			Algorithm.PrintLinkedList(node1);

			Algorithm.DeleteLinkedListNodeMiddle(node5);

			Algorithm.PrintLinkedList(node1);

            Assert.True(true);
		}

        [Fact]
        public void LRUCacheTest()
        {
			LRUCache lru = new LRUCache(5);
			lru.set(1, 4);
			lru.set(2, 4);
			lru.set(3, 4);
			lru.set(4, 4);
			lru.set(1, 69);
			lru.set(5, 4);
			lru.set(6, 23);

            Assert.Equal(lru.get(1), -1);
            Assert.Equal(lru.get(6), 23);
		}

        [Fact]
        public void MaxStackTest()
        {
			MaxStack ms = new MaxStack();
			ms.mPush(3);
			ms.mPush(11);
			ms.mPop();
			ms.mPush(4);
			ms.mPush(6);
			ms.mPop();
			ms.mPush(2);
			ms.mPop();

            Assert.Equal(ms.GetMax(), 4);
		}

  //      [Fact]
  //      public void RemoveDuplicatesTest()
  //      {
		//	LinkedList<int> list1 = new LinkedList<int>();
		//	list1.AddLast(1);
		//	list1.AddLast(1);
		//	list1.AddLast(2);

		//	LinkedList<int> list2 = new LinkedList<int>();
		//	list2.AddLast(1);
		//	list2.AddLast(1);
		//	list2.AddLast(2);
		//	list2.AddLast(3);
		//	list2.AddLast(3);
		//	list2.AddLast(3);

		//	Algorithm.RemoveDuplicates(list1);
  //          Assert.False(Algorithm.ContainsDuplicatesLinkedList(list1));

		//	Algorithm.RemoveDuplicates(list2);
  //          Assert.False(Algorithm.ContainsDuplicatesLinkedList(list2));
		//}

        [Fact]
        public void ReorderLinkedListTest()
        {
			Node node1 = new Node(1);    
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);
			Node node5 = new Node(5);
			Node node6 = new Node(6);
			Node node7 = new Node(7);
			Node node8 = new Node(8);
			node1.Next = node2;
			node2.Next = node3;
			node3.Next = node4;
			node4.Next = node5;
			node5.Next = node6;
			node6.Next = node7;
			node7.Next = node8;

			Algorithm.ReorderLinkedList(node1);
            string reorderedListSolution = "1 8 2 7 3 6 4 5";
            string reorderedListOutput = Helper.LinkedListToString(node1);
            Assert.Equal(reorderedListOutput, reorderedListSolution);

			Algorithm.ReverseLinkedList(node1);
            string reversedListSolution = "5 4 6 3 7 2 8 1";
            string reversedListOutput = Helper.LinkedListToString(node5);
            Assert.Equal(reversedListOutput, reversedListSolution);
		}
    }
}
