using System;
using System.Linq;

namespace MedianArrayElementsExtraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int arrayLength = inputArray.Length;

            if (arrayLength == 1)
            {
                Console.WriteLine("{ " + $"{inputArray[0]}" + " }");
            }
            else
            {
                if (arrayLength % 2 == 0)
                {
                    int[] evenMedianElementsArray = new int[2];

                    //evenMedianElementsArray[0] = inputArray[inputArray.Length / 2 - 1];
                    //evenMedianElementsArray[1] = inputArray[inputArray.Length / 2];

                    //Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length

                    Array.Copy(inputArray, inputArray.Length / 2 - 1, evenMedianElementsArray, 0, 2);

                    Console.WriteLine("{ " + $"{string.Join(", ", evenMedianElementsArray)}" + " }");
                }
                else
                {
                    int[] oddMedianElementsArray = new int[3];

                    //oddMedianElementsArray[0] = inputArray[inputArray.Length / 2 - 1];
                    //oddMedianElementsArray[1] = inputArray[inputArray.Length / 2];
                    //oddMedianElementsArray[2] = inputArray[inputArray.Length / 2 + 1];

                    Array.Copy(inputArray, inputArray.Length / 2 - 1, oddMedianElementsArray, 0, 3);

                    Console.WriteLine("{ " + $"{string.Join(", ", oddMedianElementsArray)}" + " }");
                }
            }
        }
    }
}
