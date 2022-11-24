using System;
using System.Linq;

namespace FirstHomeworkSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Task 1 - Find the sum of the negative array elements

            int negativeNumbersSum = 0;

            foreach (int element in array)
            {
                if (element < 0)
                {
                    negativeNumbersSum += element;
                }
            }

            Console.WriteLine(negativeNumbersSum);

            Console.WriteLine(new string('-', 40));

            // Task 2 - Find the count of the even array elements

            int evenElementsCount = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    evenElementsCount++;
                }
            }

            Console.WriteLine(evenElementsCount);

            Console.WriteLine(new string('-', 40));

            // Task 3 - Find the average of the positive array elements

            double positiveElementsSum = 0;
            double positiveElementsCount = 0;

            foreach (int element in array)
            {
                if (element > 0)
                {
                    positiveElementsSum += element;
                    positiveElementsCount++;
                }
            }

            double positiveElementsAverage = positiveElementsSum / positiveElementsCount;

            Console.WriteLine(positiveElementsAverage);

            Console.WriteLine(new string('-', 40));

            // Task 4 - Find the multiplication of array elements, which are divisible by 7

            int elementsDivisibleBySevenMultiplication = 1;

            foreach (int element in array)
            {
                if (element % 7 == 0)
                {
                    elementsDivisibleBySevenMultiplication *= element;
                }
            }

            Console.WriteLine(elementsDivisibleBySevenMultiplication);

            Console.WriteLine(new string('-', 40));

            // Task 5 - Find the minimum array element along with its index

            int minimumElement = array[0];
            int minimumElementIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimumElement)
                {
                    minimumElement = array[i];
                    minimumElementIndex = i;
                }
            }

            Console.WriteLine($"{minimumElement} - {minimumElementIndex}");

            Console.WriteLine(new string('-', 40));

            // Task 6 - Find the multiplication and the substraction of the maximum and minumum elements of the array

            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }

                if (element > max)
                {
                    max = element;
                }
            }

            Console.WriteLine(min * max);
            Console.WriteLine(max - min);

            Console.WriteLine(new string('-', 40));

            // Task 7 - Find the count of the maximum element occurrences in the array

            int maximum = array[0];
            int maximumElementOccurrences = 0;

            foreach (int element in array)
            {
                if (element > maximum)
                {
                    maximum = element;
                }
            }

            foreach (int element in array)
            {
                if (element == maximum)
                {
                    maximumElementOccurrences++;
                }
            }

            Console.WriteLine(new string('-', 40));

            Console.WriteLine(maximumElementOccurrences);

            int maxCount = 0;

            int maxElement = array[0];

            foreach (int element in array)
            {
                if (element > maxElement)
                {
                    maxElement = element;
                    maxCount = 1;
                }
                else
                {
                    if (maxElement == element)
                    {
                        maxCount++;
                    }
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
