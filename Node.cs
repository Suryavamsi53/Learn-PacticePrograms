using System;
using System.Collections.Generic;
using System.Text;

namespace LearnPracticeProgram
{
    public class Node
    {
        private string data;  // Data stored in the node.
        private Node next = null;  // Reference to the next node in the list.
        private Node prev = null;  // Reference to the previous node in the list.

        // Property to get or set the data stored in the node.
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        // Property to get or set the reference to the next node.
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        // Property to get or set the reference to the previous node.
        public Node Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }
}
