using Q1;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//8. Write a program in C to search an element in a circular linked list.
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
			Console.Write("Input the element you want to find :");
			int insertEle = int.Parse(Console.ReadLine());
			int res = newlist.SearchElement(insertEle);
			Console.WriteLine("After insertion the new list are : ");
            Console.WriteLine(res);
            newlist.DisplayList();
		}
	}
}