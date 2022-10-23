using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ");

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}
