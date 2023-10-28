using LearnPracticeProgram; // Import the LearnPracticeProgram namespace.
using System;

namespace LearnPracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp(); // Call the runApp method to execute the program.
        }

        // A method that contains the main logic of the program.
        public static void runApp()
        {
            Stack stack = new Stack(); // Create an instance of the Stack class.

            Console.WriteLine("length of stack=" + stack.getLengthOfStack()); // Output the initial length of the stack.

            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing"); // Check if the stack is empty and print a message if it is.

            // Use a loop to push nodes onto the stack.
            for (int i = 0; i < 10; i++)
            {
                Node n = new Node(); // Create a new Node instance.
                n.Data = i.ToString(); // Set the data of the node as a string representation of 'i'.
                stack.push(n); // Push the node onto the stack.
                Console.WriteLine("Length of stack=" + stack.getLengthOfStack()); // Output the updated length of the stack.
            }

            Node node = stack.pop(); // Pop a node from the stack.
            Console.WriteLine("Popped " + node.Data); // Output the data of the popped node.

            node = stack.pop(); // Pop another node from the stack.
            Console.WriteLine("Popped " + node.Data); // Output the data of the popped node.

            Console.WriteLine(stack.listContents()); // Output the contents of the stack.
        }
    }
}
