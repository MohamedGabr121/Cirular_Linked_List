using Q1;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//5. Write a program in C to insert a new node at any position in a doubly linked list.

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
			Console.Write("Input the position to insert a new node :");
			int insertpositon = int.Parse(Console.ReadLine());
			Console.Write($"nput data for the position {insertpositon} :");
			int insertNode = int.Parse(Console.ReadLine());
			newlist.InsertAtPosition(insertpositon, insertNode);
			Console.WriteLine("After insertion the new list are : ");
			newlist.DisplayList();
		}
	}
}