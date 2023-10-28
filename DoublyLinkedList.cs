using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    // Define a class called DoublyLinked to represent a doubly linked list.
    class DoublyLinked
    {
        // Define an inner class called Node to represent individual elements of the list.
        class Node
        {
            public int Data { get; set; } // Data stored in the node.
            public Node Next { get; set; } // Reference to the next node.
            public Node Previous { get; set; } // Reference to the previous node.

            // Constructor to initialize a Node with data.
            public Node(int data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }

        private Node head; // Reference to the first node (head).
        private Node tail; // Reference to the last node (tail).

        // Method to add a new node with the given data to the end of the linked list.
        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            // If the list is empty, set both head and tail to the new node.
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                // Update the next and previous references to maintain the doubly linked structure.
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }

        // Method to display the elements of the list in forward order.
        public void DisplayForward()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        // Method to display the elements of the list in reverse order.
        public void DisplayBackward()
        {
            Node current = tail;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }
            Console.WriteLine();
        }
    }

    // Define another class called DoublyLinkedList.
    class DoublyLinkedList
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            DoublyLinked list = new DoublyLinked();

            // Add elements to the doubly linked list.
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);

            Console.WriteLine("Forward:");
            list.DisplayForward(); // Display elements in forward order.

            Console.WriteLine("Backward:");
            list.DisplayBackward(); // Display elements in reverse order.
        }
    }
}
