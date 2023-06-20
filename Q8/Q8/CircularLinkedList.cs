using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class CircularLinkedList
	{
		Node head;
		public CircularLinkedList()
		{
			head = null;
		}

		public void AddNode(int data)
		{
			Node newNode = new Node(data);

			if (head == null)
			{
				head = newNode;
				newNode.Next = head;
			}
			else
			{
				Node last = head;
				while (last.Next != head)
					last = last.Next;

				last.Next = newNode;
				newNode.Next = head;
			}
		}

		public int SearchElement(int element)
		{
			if (head == null)
			{
				Console.WriteLine("The list is empty.");
				return -1;
			}

			Node current = head;
			int position = 1;
			bool found = false;

			do
			{
				if (current.Data == element)
				{
					found = true;
					break;
				}

				current = current.Next;
				position++;
			} while (current != head);

			if (found)
			{
				Console.WriteLine("Element found at node " + position);
				return position;
			}
			else
			{
				Console.WriteLine("Element not found.");
				return -1;
			}
		}

		public void DisplayList()
		{
			if (head == null)
			{
				Console.WriteLine("The list is empty.");
				return;
			}

			Node current = head;
			int count = 1;

			Console.WriteLine("Data entered in the list are:");

			do
			{
				Console.WriteLine($"Data {count} = {current.Data}");
				current = current.Next;
				count++;
			} while (current != head);
		}
	}
}
