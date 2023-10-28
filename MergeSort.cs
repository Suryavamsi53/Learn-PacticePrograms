using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    internal class MergeSort
    {
        // The entry point of the program.
        static void Main(string[] args)
        {
            runApp(); // Call the runApp method to execute the program.
        }

        // A method that contains the main logic of the program.
        public static void runApp()
        {
            // Define an array of integer marks.
            int[] marks = { 67, 90, 80, 55, 71, 92 };

            Console.WriteLine("Original Marks:");
            PrintMarks(marks); // Display the original array of marks.

            MergeSorting(marks, 0, marks.Length - 1); // Sort the array using the merge sort algorithm.

            Console.WriteLine("\nMarks After Merge Sort (Ascending Order):");
            PrintMarks(marks); // Display the sorted array of marks.
        }

        // Method to perform merge sort on an array of integers.
        public static void MergeSorting(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSorting(arr, left, mid);
                MergeSorting(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        // Method to merge two sorted subarrays into a single sorted array.
        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            // Copy elements from the main array to left and right subarrays.
            for (int i = 0; i < n1; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            int k = left;
            int x = 0;
            int y = 0;

            // Merge the two subarrays back into the main array in ascending order.
            while (x < n1 && y < n2)
            {
                if (leftArr[x] <= rightArr[y])
                {
                    arr[k] = leftArr[x];
                    x++;
                }
                else
                {
                    arr[k] = rightArr[y];
                    y++;
                }
                k++;
            }

            // Copy any remaining elements from leftArr and rightArr to the main array.
            while (x < n1)
            {
                arr[k] = leftArr[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                arr[k] = rightArr[y];
                y++;
                k++;
            }
        }

        // Method to print the array of marks.
        public static void PrintMarks(int[] arr)
        {
            foreach (int mark in arr)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
