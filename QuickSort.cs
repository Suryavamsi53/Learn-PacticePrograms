using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[10];
            marks[0] = 80;
            marks[1] = 90;
            marks[2] = 93;
            marks[3] = 76;
            marks[4] = 77;
            marks[5] = 92;
            marks[6] = 89;
            marks[7] = 78;
            marks[8] = 69;
            marks[9] = 56;

            quickSort(marks, 0, 9); // Sort the array using the Quick Sort algorithm.

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]); // Output the sorted array of marks.
            }
        }

        // Method to perform Quick Sort on an array of integers.
        public static void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = partition(arr, left, right); // Find the pivot element.
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1); // Recursively sort the left subarray.
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right); // Recursively sort the right subarray.
                }
            }
        }

        // Method to partition the array and find the pivot element.
        public static int partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left]; // Choose the leftmost element as the pivot.
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++; // Move the left index to the right.
                }
                while (arr[right] > pivot)
                {
                    right--; // Move the right index to the left.
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp; // Swap elements on the left and right sides of the pivot.
                }
                else
                {
                    return right; // Return the index of the pivot element.
                }
            }
        }
    }
}
