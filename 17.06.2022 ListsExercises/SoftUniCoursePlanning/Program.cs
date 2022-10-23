using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] commandInfo = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

            while (commandInfo[0] != "course start")
            {
                string cmd = commandInfo[0];
                string lesson = commandInfo[1];

                switch (cmd)
                {

                    case "Add":
                        if (!courses.Contains(lesson))
                        {
                            courses.Add(lesson);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(commandInfo[2]);
                        if (!courses.Contains(lesson))
                        {
                            courses.Insert(index, lesson);
                        }
                        break;

                    case "Remove":
                        if (courses.Contains(lesson))
                        {
                            courses.Remove(lesson);
                        }
                        if (courses.Contains($"{lesson}-Exercise"))
                        {
                            courses.Remove($"{lesson}-Exercise");
                            // Дали не трябва да проверя само за следващото на урока???
                        }
                        break;

                    case "Swap":
                        string secondLesson = commandInfo[2];
                        if (courses.Contains(lesson) && courses.Contains(secondLesson))
                        {
                            int firstLessonIndex = courses.IndexOf(lesson);
                            int secondLessonIndex = courses.IndexOf(secondLesson);
                            courses[firstLessonIndex] = secondLesson;
                            courses[secondLessonIndex] = lesson;

                            if (courses.Contains($"{lesson}-Exercise"))
                            {
                                courses.Remove($"{lesson}-Exercise");
                                courses.Insert(courses.IndexOf(lesson) + 1, $"{lesson}-Exercise");
                            }

                            if (courses.Contains($"{secondLesson}-Exercise"))
                            {
                                courses.Remove($"{secondLesson}-Exercise");
                                courses.Insert(courses.IndexOf(secondLesson) + 1, $"{secondLesson}-Exercise");
                            }
                        }
                        break;

                    case "Exercise":
                        if (!courses.Contains(lesson))
                        {
                            courses.Add(lesson);
                        }

                        if (!courses.Contains($"{lesson}-Exercise"))
                        {
                            courses.Insert(courses.IndexOf(lesson) + 1, $"{lesson}-Exercise");
                        }
                        break;
                }

                commandInfo = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i+1}.{courses[i]}");
            }
        }
    }
}
