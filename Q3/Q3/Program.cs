using Q1;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 3. Write a program in C to insert a node at the end of a circular linked list.

			CircularLinkedList newlist = new CircularLinkedList();
			Console.WriteLine("Enter the number of nodes:");
			int nodes = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < nodes; i++)
			{
				Console.Write("Enter input {0}: ", i + 1);
				int input = Convert.ToInt32(Console.ReadLine());
				newlist.AddNode(input);
			}
			newlist.DisplayList();
			Console.Write("Input data to be inserted at the End : ");
			int insertNode = int.Parse(Console.ReadLine());
			newlist.AddNode(insertNode);
			Console.WriteLine("After insertion the new list are : ");
			newlist.DisplayList();
		}
	}
}