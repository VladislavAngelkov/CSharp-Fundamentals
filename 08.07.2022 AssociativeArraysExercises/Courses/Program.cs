using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ");

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                string course = command[0];
                string student = command[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);

                command = Console.ReadLine().Split(" : ");
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
