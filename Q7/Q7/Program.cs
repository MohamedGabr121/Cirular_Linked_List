using Q1;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{


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
			Console.Write("I delete a new node the End :");
			
			newlist.DeleteNodeAtEnd();
			Console.WriteLine("After insertion the new list are : ");
			newlist.DisplayList();
		}
	}
}