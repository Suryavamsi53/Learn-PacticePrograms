using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    internal class SinglyLinked
    {
     
        // Create a class to represent a node in the singly linked list
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        // Create a class to represent the singly linked list
        public class SingleLinkedList
        {
            private Node head;

            public SingleLinkedList()
            {
                head = null;
            }

            // Add a new node to the end of the linked list
            public void AddNode(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            // Display the elements in the linked list
            public void DisplayList()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }

        class SinglyLinkedList
        {
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                SingleLinkedList myList = new SingleLinkedList();

                // Add elements to the linked list
                myList.AddNode(10);
                myList.AddNode(20);
                myList.AddNode(30);
                myList.AddNode(40);
                myList.AddNode(50);

                // Display the linked list
                Console.WriteLine("Linked List Elements:");
                myList.DisplayList();
            }
        }
    }

}
