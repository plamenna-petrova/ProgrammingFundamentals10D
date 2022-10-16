using System;
using System.Linq;

namespace ArraysMoreExamples
{
    public class Program
    {
        // LINQ methods for getting special information about the arrays

        static int GetMinimumElementOfArray(int[] numbersArray)
        {
            int minimumOfArrayElements = numbersArray.Min();
            return minimumOfArrayElements;
        }

        static int GetMaximumElementOfArray(int[] numbersArray)
        {
            int maximumOfArrayElements = numbersArray.Max();
            return maximumOfArrayElements;
        }

        static int GetSumOfArrayElements(int[] numbersArray)
        {
            int sumOfArrayElements = numbersArray.Sum();
            return sumOfArrayElements;
        }

        static double GetAverageOfArrayElements(int[] numbersArray)
        {
            double arrayElementsAverage = numbersArray.Average();
            return arrayElementsAverage;
        }

        // manual array algorithms

        static int DetermineMaximumElementOfArray(int[] numbersArray)
        {
            int maximumElement = numbersArray[0];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > maximumElement)
                {
                    maximumElement = numbersArray[i];
                }
            }

            return maximumElement;
        }

        static int DetermineMinimumElementOfArray(int[] numbersArray)
        {
            int minimumElement = numbersArray[0];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] < minimumElement)
                {
                    minimumElement = numbersArray[i];
                }
            }

            return minimumElement;
        }

        static int CalculateSumOfArrayElements(int[] numbersArray)
        {
            int sumOfArrayElements = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                sumOfArrayElements += numbersArray[i];
            }

            return sumOfArrayElements;
        }

        static double DetermineAverageOfArrayElements(int[] numbersArray)
        {
            int sumOfArrayElements = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                sumOfArrayElements += numbersArray[i];
            }

            double averageOfArrayElements = (double)sumOfArrayElements / numbersArray.Length;

            return averageOfArrayElements;
        }

        static int GetTotalCountOfSearchedElementInArray(int[] numbersArray, int elementToFind)
        {
            int counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == elementToFind)
                {
                    counter++;
                }
            }

            return counter;
        }

        static int[] EnterArrayElementsWithFixedCount(int elementsCount)
        {
            int[] numbersArray = new int[elementsCount];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            return numbersArray;
        }

        static int[] EnterArrayElementsOnASingleLine()
        {
            string consoleInputArrayValues = Console.ReadLine();
            string[] inputItemsAsStrings = consoleInputArrayValues.Split(' ');

            int[] numbersArray = new int[inputItemsAsStrings.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(inputItemsAsStrings[i]);
            }

            return numbersArray;
        }

        static void DisplayArrayElements(int[] numbersArray)
        {
            foreach (var arrayElement in numbersArray)
            {
                Console.Write($"{arrayElement} ");
            }
            Console.WriteLine();
        }

        static void DisplaySpecificArrayInformation(int[] numbersArray)
        {
            Console.WriteLine($"The minimum element of the array is : " +
             $"{DetermineMaximumElementOfArray(numbersArray)}");
            Console.WriteLine($"The minimum element of the array is : " +
                $"{DetermineMinimumElementOfArray(numbersArray)}");
            Console.WriteLine($"The sum of the elements of the array is : " +
                $"{CalculateSumOfArrayElements(numbersArray)}");
            Console.WriteLine($"The elements' average of the array is : " +
                $"{Math.Round(DetermineAverageOfArrayElements(numbersArray))}");
        }

        static void Main(string[] args)
        {
            // working with arrays - crash course

            // hardcoded arrays

            int[] hardcodedArrayOfIntegers = new int[] { 10, 12, 14, 112, 1, 3 };

            foreach (var arrayElement in hardcodedArrayOfIntegers)
            {
                Console.Write($"{arrayElement} ");
                // or 
                //Console.Write("{0}", arrayElement);
            }
            Console.WriteLine();

            // arrays with a fixed length

            int[] arrayWithFixedLength = new int[10];

            // console input

            int fixedLength = arrayWithFixedLength.Length;

            for (int i = 0; i < fixedLength; i++)
            {
                arrayWithFixedLength[i] = int.Parse(Console.ReadLine());
            }

            // console output

            for (int i = 0; i < fixedLength; i++)
            {
                Console.Write($"{arrayWithFixedLength[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            string[] stringNumbersInput = Console.ReadLine().Split(' ');
            int[] numbersInputArray = stringNumbersInput.Select(int.Parse).ToArray();

            //int[] numbersInputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Console.WriteLine($"Min = {numbers.Min()}");
            //Console.WriteLine($"Max = {numbers.Max()}");
            //Console.WriteLine($"Sum = {numbers.Sum()}");
            //Console.WriteLine($"Average = {numbers.Average()}");

            Console.WriteLine($"Min = {GetMinimumElementOfArray(numbersInputArray)}");
            Console.WriteLine($"Max = {GetMaximumElementOfArray(numbersInputArray)}");
            Console.WriteLine($"Sum = {GetSumOfArrayElements(numbersInputArray)}");
            Console.WriteLine($"Average = {Math.Round(GetAverageOfArrayElements(numbersInputArray), 2):F2}");

            // the implementation of the pre-defined in-method logic for manual array algorithms of basic type
            Console.WriteLine($"The minimum element of the hardcoded array is : " +
                $"{DetermineMaximumElementOfArray(hardcodedArrayOfIntegers)}");
            Console.WriteLine($"The minimum element of the hardcoded array is : " +
                $"{DetermineMinimumElementOfArray(hardcodedArrayOfIntegers)}");
            Console.WriteLine($"The sum of the elements of the hardcoded array is :" +
                $"{CalculateSumOfArrayElements(hardcodedArrayOfIntegers)}");
            Console.WriteLine($"The elements' average of the hardcoded array is : " +
                $"{Math.Round(DetermineAverageOfArrayElements(hardcodedArrayOfIntegers), 2):F2}");

            Console.WriteLine("--------------------------------------");

            // console input / output of array elements along with the display
            // of their specific pieces of information
            // the core logic is moved into separate methods
            int[] exampleArray = EnterArrayElementsWithFixedCount(5);
            DisplayArrayElements(exampleArray);
            DisplaySpecificArrayInformation(exampleArray);

            int[] anotherArrayExample = EnterArrayElementsOnASingleLine();
            DisplayArrayElements(anotherArrayExample);
            DisplaySpecificArrayInformation(anotherArrayExample);

            Console.WriteLine("--------------------------------------");

            Console.Write("Enter element to search in the array : ");

            int element = int.Parse(Console.ReadLine());

            bool isElementFoundInArray = anotherArrayExample.Contains(element);

            if (isElementFoundInArray)
            {
                Console.WriteLine("The {0} is contained {1} times in the array", element,
                    GetTotalCountOfSearchedElementInArray(anotherArrayExample, element));
            }
            else
            {
                Console.WriteLine("An element with the value of {0} cannot be found in the array", element);
            }

            Console.ReadKey();
        }
    }
}
