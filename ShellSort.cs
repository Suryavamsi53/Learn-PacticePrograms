using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    internal class ShellSort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = { 67, 90, 80, 55, 71, 92 };

            Console.WriteLine("Original Marks:");
            PrintMarks(marks); // Output the original array of marks.

            ShellSorting(marks); // Sort the array using the Shell Sort algorithm.

            Console.WriteLine("\nMarks After Shell Sort (Ascending Order):");
            PrintMarks(marks); // Output the sorted array of marks.
        }

        // Method to perform Shell Sort on an array of integers.
        public static void ShellSorting(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        // Method to print the array of marks.
        public static void PrintMarks(int[] arr)
        {
            foreach (int mark in arr)
            {
                Console.Write(mark + " "); // Output each mark followed by a space.
            }
            Console.WriteLine(); // Move to the next line after printing all marks.
        }
    }
}
