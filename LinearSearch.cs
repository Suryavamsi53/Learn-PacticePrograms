using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{

class LinearSearch
    {
        static int Search(int[] arr, int target)
        {
            //Traversal the elements across the Indexes from index{0}th Position to arr.length-1;
            for (int i = 0; i < arr.Length; i++)
            {
                //if arr[i] means while traversing if the target element found then return i th position means index of found position 
                if (arr[i] == target)
                    return i; // Return the index if the element is found
            }
            return -1; // Return -1 if the element is not found
        }

        static void Main(string[] args)
        {
            // Manually entered elements 
            int[] array = { 9, 13, 15, 17, 21, 23, 27, 31, 33, 36, 42, 47, 42, 51, 52, 54, 56, 61, 66};
            //int target = 56;
            //we can enter the target here
            Console.WriteLine("Enter the Element You Want to Search for: ");
            int target = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());


            //we use Search Method to find the element, if target found in array 
            int result = Search(array, target);

            //if result is not equals to -1 we found the target if result is -1, the target is not available in the Array 
            if (result != -1)
            {
                Console.WriteLine($"Element {target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array");
            }
        }
    }
}
