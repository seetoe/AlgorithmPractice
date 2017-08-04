using System;

public partial class Algorithm {
	public class LinkedListNode
	{
		private int value;
		private LinkedListNode next;

		public LinkedListNode(int value, LinkedListNode next)
		{
			this.value = value;
			this.next = next;
		}

		public int Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		public LinkedListNode Next
		{
			get
			{
				return this.next;
			}
			set
			{
				this.next = value;
			}
		}
	}
}


