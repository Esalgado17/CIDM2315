using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
    class Student
    {
        private int StudentID;
        private string StudentName;
        public static List<Student> StudentList = new List<Student>();

        public Student(int StudentID, string StudentName)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            StudentList.Add(this);
        }

        public string Name{
            get { return StudentName; }
        }

        public void PrintInfo(){
            Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
        }
    }
    class Program
{
        static void Main(string[] args)
        {
            Student alice = new Student(111, "Alice");
            Student bob = new Student(222, "Bob");
            Student cathy = new Student(333, "Cathy");
            Student david = new Student(444, "David");

            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.6);

            if (gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
            }

            double totalGPA = 0.0;
            foreach (var student in Student.StudentList)
            {
                if (gradebook.ContainsKey(student.Name))
                {
                    totalGPA += gradebook[student.Name];
                }
            }

            double averageGpa = totalGPA / Student.StudentList.Count;
            Console.WriteLine($"Average GPA: {averageGpa}");

            Console.WriteLine("Students with GPA greater than average:");
            foreach (var student in Student.StudentList)
            {
                if (gradebook.ContainsKey(student.Name) & gradebook[student.Name] > averageGpa)
                {
                    student.PrintInfo();
                }
            }
        }
    }
}