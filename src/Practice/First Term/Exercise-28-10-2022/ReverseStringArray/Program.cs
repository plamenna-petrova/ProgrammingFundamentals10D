using System;
using System.Linq;

namespace ReverseStringArray
{
    public class Program
    {
        static void SwapArrayElements(string[] arrayToSwap, int i, int j)
        {
            string oldElement = arrayToSwap[i];
            arrayToSwap[i] = arrayToSwap[j];
            arrayToSwap[j] = oldElement;
        }

        static void Main(string[] args)
        {
            string[] exampleArray = Console.ReadLine().Split(' ');

            for (int i = exampleArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{exampleArray[i]} ");
            }

            Console.WriteLine();

            string[] reversedArray = exampleArray.Reverse().ToArray();

            foreach (string element in reversedArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();

            string reversedArrayString = string.Join(" ", exampleArray.Reverse());

            Console.WriteLine(reversedArrayString);

            for (int i = 0; i < exampleArray.Length / 2; i++)
            {
                //SwapArrayElements(exampleArray, i, exampleArray.Length - 1 - i);
                string oldElement = exampleArray[i];
                //string newElement = exampleArray[exampleArray.Length - 1 - i];
                exampleArray[i] = exampleArray[exampleArray.Length - 1 - i];
                exampleArray[exampleArray.Length - 1 - i] = oldElement;
            }

            Console.WriteLine(string.Join(" ", exampleArray));
        }
    }
}
