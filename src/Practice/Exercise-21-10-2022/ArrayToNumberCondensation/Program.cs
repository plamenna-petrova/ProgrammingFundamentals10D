using System;
using System.Linq;

namespace ArrayToNumberCondensation
{
    public class Program
    {
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

        static int CondenseArrayToNumber(int[] numbersArray)
        {
            while (numbersArray.Length > 1)
            {
                int reducedArrayLength = numbersArray.Length - 1;

                int[] condensedArray = new int[reducedArrayLength];

                for (int i = 0; i < reducedArrayLength; i++)
                {
                    condensedArray[i] = numbersArray[i] + numbersArray[i + 1];
                }

                numbersArray = condensedArray;
            }

            return numbersArray[0];
        }

        static void Main(string[] args)
        {
            int[] exampleArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Console.WriteLine(CondenseArrayToNumber(exampleArray));

            while (exampleArray.Length > 1)
            {
                int reducedLength = exampleArray.Length - 1;

                int[] condensedArray = new int[reducedLength];

                for (int i = 0; i < reducedLength; i++)
                {
                    condensedArray[i] = exampleArray[i] + exampleArray[i + 1];
                }

                exampleArray = condensedArray;
            }

            Console.WriteLine(exampleArray[0]);
        }
    }
}
