using Q1;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 6. Write a program in C to delete a node from the middle of a circular linked list.

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
			Console.Write("Input the position to delete a new node :");
			int insertpositon = int.Parse(Console.ReadLine());
			newlist.DeleteNode(insertpositon);
			Console.WriteLine("After insertion the new list are : ");
			newlist.DisplayList();
		}
	}
}