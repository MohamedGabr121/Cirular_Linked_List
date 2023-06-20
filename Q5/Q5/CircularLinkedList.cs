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
		
    public void InsertAtPosition(int position, int data)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        Node newNode = new Node(data);

        if (head == null)
        {
            if (position == 1)
            {
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
            return;
        }

        if (position == 1)
        {
            Node last = head;
            while (last.Next != head)
                last = last.Next;

            newNode.Next = head;
            head = newNode;
            last.Next = head;
        }
        else
        {
            Node current = head;
            Node previous = null;
            int count = 1;

            while (current.Next != head && count < position)
            {
                previous = current;
                current = current.Next;
                count++;
            }

         
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
