using System;

namespace ArrayMethodsBasics
{
    public class Program
    {
        static void Main(string[] args) 
        {
            // Reverse
            int[] arrayToReverse = new int[] { 2, 4, -5, 1, 10 }; 
            Array.Reverse(arrayToReverse);
            Console.WriteLine(string.Join(" ", arrayToReverse));

            // Sort 
            int[] arrayToSort = new int[] { 2, 4, -5, 1, 10 }; 
            Array.Sort(arrayToSort);
            Console.WriteLine(string.Join(" ", arrayToSort));

            // Clear
            int[] arrayToClear = new int[] { 2, 4, -5, 1, 10 };

            int startingClearingIndex = 1;
            int clearingLength = 2;

            Array.Clear(arrayToClear, startingClearingIndex, clearingLength);
            Console.WriteLine(string.Join(" ", arrayToClear));

            // CopyTo
            int[] sourceCopyToArray = new int[] { 1, 2, 3 };
            int[] destinationCopyToArray = new int[] { 2, 4, -5, 1, 10 };

            int startingIndexForCopying = 1;

            sourceCopyToArray.CopyTo(destinationCopyToArray, startingIndexForCopying);

            Console.WriteLine(string.Join(" ", destinationCopyToArray));

            // Copy
            int[] sourceCopyArray = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] destinationCopyArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            Array.Copy(sourceCopyArray, 4, destinationCopyArray, 2, 3);
            Console.WriteLine(string.Join(" ", destinationCopyArray));
        }
    }
}
