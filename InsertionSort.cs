using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    class InsertionSort
    {
        // The entry point of the program.
        static void Main(string[] args)
        {
            runApp(); // Call the runApp method to execute the program.
        }

        // A method that contains the main logic of the program.
        public static void runApp()
        {
            // Declare an array to store the names of students.
            string[] students = new string[10];

            // Initialize the array with student names.
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

            int n = 10, i, j, flag;
            string val;

            // Perform insertion sort on the array of student names.
            for (i = 1; i < n; i++)
            {
                val = students[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    // Compare the current name with the previous name.
                    if (val.CompareTo(students[j]) < 0)
                    {
                        students[j + 1] = students[j];
                        j--;
                        students[j + 1] = val;
                    }
                    else
                    {
                        flag = 1; // Set flag to 1 if the name is in its correct position.
                    }
                }
            }

            // Display the sorted list of student names.
            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
