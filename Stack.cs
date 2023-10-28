using System.Collections.Generic;
using System.Text;

namespace LearnPracticeProgram
{
    public class Stack
    {
        private Node root = null;  // The root node of the stack (the top).
        private Node current = null;  // The current node being processed.
        private int length;  // The number of nodes in the stack.

        // Property to get or set the root node.
        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        // Property to get or set the length of the stack.
        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        // Method to push a node onto the stack.
        public void push(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;  // If the stack is empty, the pushed node becomes the root.
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;  // Add the node to the end of the stack.
                node.Prev = current;
                current = node;
                length++;
            }
        }

        // Method to pop a node from the stack.
        public Node pop()
        {
            if (current == null)
            {
                return null;  // If the stack is empty, return null.
            }
            else if (current == root)
            {
                Node n = current;
                current = null;
                root = null;
                length = 0;
                return n;  // If there's only one node in the stack, remove it.
            }
            else
            {
                Node n = current;
                current = current.Prev;
                current.Next = null;
                length--;
                return n;  // Pop the current node and update the stack.
            }
        }

        // Method to peek at the next node without popping it.
        public Node peek()
        {
            if (current == null || current.Next == null)
                return null;  // If the stack is empty or only one node is left, return null.
            else
                return current.Next;  // Return the next node in the stack.
        }

        // Method to get the root node and reset the current node.
        public Node getRoot()
        {
            current = root;
            return this.root;
        }

        // Method to get the length of the stack.
        public int getLengthOfStack()
        {
            return this.length;
        }

        // Method to list the contents of the stack as a string.
        public string listContents()
        {
            string retVal = "";
            current = root;
            while (current != null)
            {
                retVal += current.Data + " ";  // Concatenate the data of each node.
                current = current.Next;
            }
            current = root;  // Reset the current node.
            return retVal;
        }
    }
}
