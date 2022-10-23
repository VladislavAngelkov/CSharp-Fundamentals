using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string student = Console.ReadLine();

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<double>());
                }

                studentsGrades[student].Add(double.Parse(Console.ReadLine()));
            }

            foreach (var student in studentsGrades.Where(x=>x.Value.Average()>=4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
