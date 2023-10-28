using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Learn_PacticePrograms
    {
        internal class Recursion
        {
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                // Create an array of student names
                string[] students = new string[10];
                students[0] = "Karuna";
                students[1] = "Mark";
                students[2] = "Advaith";
                students[3] = "Sangeeta";
                students[4] = "Nazia";
                students[5] = "Faisal";
                students[6] = "Tania";
                students[7] = "Guru";
                students[8] = "Chandni";
                students[9] = "Kamleshwar";

                int currElem = 0;

                // Call the recursive method to print the array of student names
                printViaRecursion(students, currElem);
            }

            public static void printViaRecursion(string[] arr, int currElem)
            {
                // Print the current element
                Console.WriteLine(arr[currElem]);

                if (currElem < arr.Length - 1)
                {
                    // If not at the end of the array, recursively call the method for the next element
                    printViaRecursion(arr, currElem + 1);
                }
            }
        }
    }
