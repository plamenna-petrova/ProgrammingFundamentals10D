using System;

namespace ArrayRotationWithSummation
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

        static int[] ExecuteRotationAndSummation(int[] numbersArray, int rotations)
        {
            int[] rotatedArray = new int[numbersArray.Length];

            int[] summationArray = new int[numbersArray.Length];

            // explanation

            // 4 3 2 -1
            // 1) a new array is created for storing the rotation values
            // 1) the first element in the rotated array gets the value of the last element of the initial array
            // 2) current result: -1 _ _ _
            // 3) the initial array is iterated x times, where x is the value of the initial array's length,
            // decremented with 1
            // 4) during these iteration, which in our case are 3, the elements of the rotated array, other than
            // the first one get the consecutive values of the intial array elements, until the iterations are over
            // that is : -1 _ _ _ -> -1 4 _ _ -> -1 4 3 _ -> -1 4 3 2
            // 5) by using another separate for loop, the rotated array elements are copied into the initial array
            // 6) in the same for loop, each of the summation array elements gets it's value incremented by the
            // current value of the corresponding rotated array element, i.e. the summation array : -1 4 3 2
            // 7) the same process is repeated, till the exhaustion of the rotations : 
            // 2) 2 _ _ _
            // 3) 2 _ _ _ -> 2 -1 _ _ -> 2 -1 4 _ -> 2 -1 4 3
            // 6) summation array : -1 4 3 2
            //                    +
            //                       2 -1 4 3
            //                    =  1 3 7 5 

            for (int i = 0; i < rotations; i++)
            {
                int lastNumbersArrayIndex = numbersArray.Length - 1;

                rotatedArray[0] = numbersArray[lastNumbersArrayIndex];

                for (int j = 0; j < numbersArray.Length - 1; j++)
                {
                    rotatedArray[j + 1] = numbersArray[j];
                }

                for (int k = 0; k < numbersArray.Length; k++)
                {
                    numbersArray[k] = rotatedArray[k];
                    summationArray[k] += rotatedArray[k];
                }
            }

            // via a while loop - an alternative approach to the nested for loops

            //while (rotations > 0)
            //{
            //    int lastNumbersArrayIndex = numbersArray.Length - 1;

            //    rotatedArray[0] = numbersArray[lastNumbersArrayIndex];

            //    for (int j = 0; j < numbersArray.Length - 1; j++)
            //    {
            //        rotatedArray[j + 1] = numbersArray[j];
            //    }

            //    for (int k = 0; k < numbersArray.Length; k++)
            //    {
            //        numbersArray[k] = rotatedArray[k];
            //        summationArray[k] += rotatedArray[k];
            //    }

            //    rotations--;
            //}

            return summationArray;
        }

        static int[] ExecuteRotationAndSummationWithReversedLoop(int[] numbersArray, int rotations)
        {
            int[] summationArray = new int[numbersArray.Length];

            // 4 3 2 -1 -> reversed to -1 2 3 4 -> rotated to -> 4 3 2 2 -> 4 3 3 2 -> 4 4 3 2
            // result (the first element is replaced with the last one) : -1 4 3 2

            for (int i = 0; i < rotations; i++)
            {
                int reducedNumbersArrayLength = numbersArray.Length - 1;

                int lastElement = numbersArray[reducedNumbersArrayLength];

                for (int j = reducedNumbersArrayLength; j > 0; j--)
                {
                    numbersArray[j] = numbersArray[j - 1];
                }

                numbersArray[0] = lastElement;

                for (int k = 0; k < numbersArray.Length; k++)
                {
                    summationArray[k] += numbersArray[k];
                }
            }

            return summationArray;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = EnterArrayElementsOnASingleLine();
            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] resultArray = ExecuteRotationAndSummation(exampleArray, numberOfRotations);

            //int[] resultArray = ExecuteRotationAndSummationWithReversedLoop(exampleArray, numberOfRotations);

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
