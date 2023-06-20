namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Write a program in C# to create and display a circular linked list.

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
		}
	}
}