﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split();

            List<Student> students = new List<Student>();

            while (studentInfo[0] != "end")
            {
                Student student = new Student();
                student.FirstName = studentInfo[0];
                student.LastName = studentInfo[1];
                student.Age = int.Parse(studentInfo[2]);
                student.HomeTown = studentInfo[3];

                students.Add(student);

                studentInfo = Console.ReadLine().Split();
            }

            string town = Console.ReadLine();

            foreach (var student in students.Where(x=>x.HomeTown == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
