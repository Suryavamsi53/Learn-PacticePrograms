using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_PacticePrograms
{
    // Define a class to represent a Student.
    class Student
    {
        public string Name { get; set; } // Property to store the student's name.
        public int Score { get; set; }   // Property to store the student's score.

        // Constructor to initialize a Student object with a name and score.
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    // Define a class for the BubbleSort program.
    class BubbleSort
    {
        static void Main(string[] args)
        {
            runApp(); // Call the runApp method to execute the program.
        }

        // A method that contains the main logic of the program.
        public static void runApp()
        {
            // Create an array of Student objects.
            Student[] students = new Student[]
            {
                new Student("Marie", 85),
                new Student("Nick", 74),
                new Student("Negan", 92),
                new Student("David", 68),
            };

            Console.WriteLine("Original Array of Students:");
            PrintStudents(students); // Display the original array of students.

            BubbleSorting(students); // Sort the array using the bubble sort algorithm.

            Console.WriteLine("\nArray of Students After Bubble Sort (by Score):");
            PrintStudents(students); // Display the sorted array of students.
        }

        // Method to perform bubble sort on an array of students based on their scores.
        public static void BubbleSorting(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].Score > arr[j + 1].Score)
                    {
                        // Swap arr[j] and arr[j+1] if the current score is greater than the next score.
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Method to print the details of students in the array.
        public static void PrintStudents(Student[] arr)
        {
            foreach (Student student in arr)
            {
                Console.WriteLine($"{student.Name}: {student.Score}");
            }
        }
    }
}
