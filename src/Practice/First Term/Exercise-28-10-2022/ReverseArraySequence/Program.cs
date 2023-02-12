using System;
using System.Linq;

namespace ReverseArraySequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfArrayElements = int.Parse(Console.ReadLine());

            int[] exampleArray = new int[countOfArrayElements];

            for (int i = 0; i < exampleArray.Length; i++)
            {
                exampleArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = exampleArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{exampleArray[i]} ");
            }

            Console.WriteLine();

            int[] reversedArray = exampleArray.Reverse().ToArray();

            foreach (int element in reversedArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();

            string reversedArrayString = string.Join(" ", exampleArray.Reverse());

            Console.WriteLine(reversedArrayString);
        }
    }
}
