using System;
using System.Linq;

namespace Exercise_14_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double sumOfArrayElements = 0;

            //int sumOfArrayElements = 0;

            int sumOfEvenArrayElements = 0;
            int sumOfOddArrayElements = 0;

            foreach (int arrayElement in inputArray)
            {
                sumOfArrayElements += arrayElement;

                if (arrayElement % 2 == 0)
                {
                    sumOfEvenArrayElements += arrayElement;
                }
                else
                {
                    sumOfOddArrayElements += arrayElement;
                }
            }

            int sumOfArrayElementsAtEvenPositions = 0;
            int sumOfArrayElementsAtOddPositions = 0;

            int sumOfArrayElementsDivisibleByThree = 0;

            int elementToFind = int.Parse(Console.ReadLine());

            int inputElementOccurrencesCounter = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfArrayElementsAtEvenPositions += inputArray[i];
                }
                else
                {
                    sumOfArrayElementsAtOddPositions += inputArray[i];
                }

                if (inputArray[i] % 3 == 0)
                {
                    sumOfArrayElementsDivisibleByThree += inputArray[i];
                }

                if (inputArray[i] == elementToFind)
                {
                    inputElementOccurrencesCounter++;
                }
            }

            // cast the expression to double when the sum type of int type
            //double average = (double) sumOfArrayElements / inputArray.Length;

            double average = sumOfArrayElements / inputArray.Length;

            Console.WriteLine($"Sum = {sumOfArrayElements}");
            Console.WriteLine($"Sum = {inputArray.Sum()}");
            Console.WriteLine($"Sum of even array elements = {sumOfEvenArrayElements}");
            Console.WriteLine($"Sum of odd array elements = {sumOfOddArrayElements}");
            Console.WriteLine($"Sum of array elements at even positions = {sumOfArrayElementsAtEvenPositions}");
            Console.WriteLine($"Sum of array elements at odd positions = {sumOfArrayElementsAtOddPositions}");
            Console.WriteLine($"Sum of array elements, divisible by three = {sumOfArrayElementsDivisibleByThree}");
            Console.WriteLine("Average = {0:F2}", Math.Round(inputArray.Average(), 2));
            Console.WriteLine("Average = {0:F2}", Math.Round(average, 2));
            
            if (inputArray.Contains(elementToFind))
            {
                Console.WriteLine("The element {0} is contained {1} times in the array", elementToFind, inputElementOccurrencesCounter);
            }
            else
            {
                Console.WriteLine("Such element cannot be found in the array");
            }
        }
    }
}
