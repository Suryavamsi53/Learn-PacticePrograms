using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    internal class BinarySearch
    {



            // Recursive binary search function
            static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Return the index if the element is found

                if (arr[mid] > target)
                    return BinarySearchRecursive(arr, target, left, mid - 1); // Search the left half

                return BinarySearchRecursive(arr, target, mid + 1, right); // Search the right half
            }

            return -1; // Return -1 if the element is not found
        }

        /*     // Iterative binary search function
             static int BinarySearchIterative(int[] arr, int target)
             {
                 int left = 0;
                 int right = arr.Length - 1;

                 while (left <= right)
                 {
                     int mid = left + (right - left) / 2;

                     if (arr[mid] == target)
                         return mid; // Return the index if the element is found

                     if (arr[mid] > target)
                         right = mid - 1; // Search the left half
                     else
                         left = mid + 1; // Search the right half
                 }

                 return -1; // Return -1 if the element is not found
             }
     */

        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {


            int[] array = { 12, 23, 34, 45, 56, 67, 78, 89, 90, 100 };
            int target = 56;

            // Perform binary search using the recursive method
            int resultRecursive = BinarySearchRecursive(array, target, 0, array.Length - 1);

            if (resultRecursive != -1)
            {
                Console.WriteLine($"Element {target} found at index (Using Recursive Approach): {resultRecursive}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found (recursive)");
            }

            /*// Perform binary search using the iterative method
            int resultIterative = BinarySearchIterative(array, target);

            if (resultIterative != -1)
            {
                Console.WriteLine($"Element {target} found at index (Using iterative Approach): {resultIterative}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found (iterative)");
            }*/
        }
    }
}
