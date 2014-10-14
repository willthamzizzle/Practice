using System;

namespace LinkedList
{
	public class List
	{

		public class Node
		{
			public object NodeData;
			public Node Next;
		}

		private int size;
		// getter for size
		public int Count
		{
			get {
				return size;
			}
		}

		private Node head;
		private Node current;

		// constructor
		public List()
		{
			size = 0;
			head = null;
		}

		// print the contents in all of the nodes duh
		public void printAllNodes()
		{
			Node current = head;

			while (current.Next != null) 
			{
				Console.Write (current.NodeData);
				current = current.Next;
			}
		}

		public void Add(object data)
		{
			Node toAdd = new Node ();
			toAdd.NodeData = data;
			Node current = head;
			current.Next = toAdd;
		}




		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}
