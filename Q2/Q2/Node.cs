using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Node
	{
		int data;
		Node next;

        public Node(int value)
        {
            data = value;
            next = null;
            
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
