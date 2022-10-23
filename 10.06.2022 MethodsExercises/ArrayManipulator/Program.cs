using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ');
            while (command[0]!="end")
            {
                if (command[0] == "exchange")
                {
                    array = Exchange(array, int.Parse(command[1]));
                }
                else if (command[0] == "max")
                {
                    MaxElement(command[1], array);
                }
                else if (command[0] == "min")
                {
                    MinElement(command[1], array);
                }
                else if (command[0] == "first")
                {
                    FirstElements(command[2], int.Parse(command[1]), array);
                }
                else if (command[0] == "last")
                {
                    LastElements(command[2], int.Parse(command[1]), array);
                }
                command = Console.ReadLine().Split();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");
        }

        static int[] Exchange(int[] array, int index)
        {
            if (index<0 || index>=array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            else
            {
                int[] newArray = new int[array.Length];
                int newArrayIndexCounter = 0;
                for (int i = index + 1; i < array.Length; i++)
                {
                    newArray[newArrayIndexCounter] = array[i];
                    newArrayIndexCounter++;
                }
                for (int i = 0; i <= index; i++)
                {
                    newArray[newArrayIndexCounter] = array[i];
                    newArrayIndexCounter++;
                }
                return newArray;
            } 
        }

        static void MaxElement(string OddOrEven, int[] array)
        {
            if (OddOrEven == "odd")
            {
                int maxNumber = int.MinValue;
                int maxIndex = 0;
                bool maxIsFound = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                        maxIsFound = true;
                    }
                }
                if (maxIsFound)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (OddOrEven == "even")
            {
                int maxNumber = int.MinValue;
                int maxIndex = 0;
                bool maxIsFound = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                        maxIsFound = true;
                    }
                }
                if (maxIsFound)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void MinElement(string OddOrEven, int[] array)
        {
            if (OddOrEven == "odd")
            {
                int minNumber = int.MaxValue;
                int minIndex = 0;
                bool minIsFound = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        minIndex = i;
                        minIsFound = true;
                    }
                }
                if (minIsFound)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (OddOrEven == "even")
            {
                int minNumber = int.MaxValue;
                int minIndex = 0;
                bool minIsFound = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        minIndex = i;
                        minIsFound = true;
                    }
                }
                if (minIsFound)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void FirstElements(string oddOrEven, int countOfElements, int[] array)
        {
            if (oddOrEven == "odd")
            {
                if (countOfElements > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
                int[] newArray = new int[array.Length];
                int elementCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && elementCounter < countOfElements)
                    {
                        newArray[elementCounter] = array[i];
                        elementCounter++;
                    }
                }
                int[] finalArray = new int[elementCounter];
                for (int i = 0; i < finalArray.Length; i++)
                {
                    finalArray[i] = newArray[i];
                }
                Console.Write("[");
                if (elementCounter>0)
                {
                    Console.Write(string.Join(", ", finalArray));
                }
                Console.WriteLine("]");
            }
            else if (oddOrEven == "even")
            {
                if (countOfElements > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
                int[] newArray = new int[array.Length];
                int elementCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && elementCounter < countOfElements)
                    {
                        newArray[elementCounter] = array[i];
                        elementCounter++;
                    }
                }
                int[] finalArray = new int[elementCounter];
                for (int i = 0; i < finalArray.Length; i++)
                {
                    finalArray[i] = newArray[i];
                }
                Console.Write("[");
                if (elementCounter > 0)
                {
                    Console.Write(string.Join(", ", finalArray));
                }
                Console.WriteLine("]");
            }
        }

        static void LastElements(string oddOrEven, int countOfElements, int[] array)
        {
            if (oddOrEven == "odd")
            {
                if (countOfElements > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
                array = array.Reverse().ToArray();
                int[] newArray = new int[array.Length];
                int elementCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && elementCounter < countOfElements)
                    {
                        newArray[elementCounter] = array[i];
                        elementCounter++;
                    }
                }
                int[] finalArray = new int[elementCounter];
                for (int i = 0; i < finalArray.Length; i++)
                {
                    finalArray[i] = newArray[i];
                }
                finalArray = finalArray.Reverse().ToArray();
                Console.Write("[");
                if (elementCounter > 0)
                {
                    Console.Write(string.Join(", ", finalArray));
                }
                Console.WriteLine("]");
            }
            else if (oddOrEven == "even")
            {
                if (countOfElements > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }
                array = array.Reverse().ToArray();
                int[] newArray = new int[array.Length];
                int elementCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && elementCounter < countOfElements)
                    {
                        newArray[elementCounter] = array[i];
                        elementCounter++;
                    }
                }
                int[] finalArray = new int[elementCounter];
                for (int i = 0; i < finalArray.Length; i++)
                {
                    finalArray[i] = newArray[i];
                }
                finalArray = finalArray.Reverse().ToArray();
                Console.Write("[");
                if (elementCounter > 0)
                {
                    Console.Write(string.Join(", ", finalArray));
                }
                Console.WriteLine("]");
            }
        }
    }
}
