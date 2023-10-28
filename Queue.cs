using System;
using System.Collections.Generic;
using System.Text;

namespace LearnPracticeProgram
{
    public class Queue
    {
        private int[] ele;  // Array to store queue elements.
        private int front;   // Index of the front element.
        private int rear;    // Index of the rear element.
        private int max;     // Maximum size of the queue.

        public Queue(int size)
        {
            ele = new int[size]; // Initialize the queue with the specified size.
            front = 0;           // Initialize the front index.
            rear = -1;           // Initialize the rear index.
            max = size;          // Set the maximum size of the queue.
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                return;  // If the rear index is at the maximum, no more insertions are allowed.
            }
            else
            {
                ele[++rear] = item; // Insert the item at the rear and increment the rear index.
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                return -1; // If the front index is greater than the rear index, the queue is empty.
            }
            else
            {
                return ele[front++]; // Remove and return the item at the front and increment the front index.
            }
        }

        public string printQueue()
        {
            string retVal = "";
            if (front == rear + 1)
            {
                return retVal; // If the queue is empty, return an empty string.
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    retVal += ele[i] + " "; // Create a string representation of the queue elements.
                }
            }
            return retVal;
        }
    }

    class QueueProgram
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Queue Q = new Queue(10);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);
            Q.insert(60);
            Q.insert(70);
            Q.insert(80);
            Q.insert(90);
            Q.insert(100);
            Console.WriteLine("After Insertions:");
            Console.WriteLine(Q.printQueue()); // Print the queue after insertions.

            Q.delete();
            Q.delete();
            Q.delete();

            Console.WriteLine("After Deletions:");
            Console.WriteLine(Q.printQueue()); // Print the queue after deletions.
        }
    }
}
