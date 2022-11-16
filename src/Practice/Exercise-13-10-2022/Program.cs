using System;
using System.Linq;

namespace Exercise_13_10_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("-----------------------------");

            // by using the Min() and Max() methods respectivelty
            Console.WriteLine($"Min = {exampleArray.Min()}");
            Console.WriteLine($"Max = {exampleArray.Max()}");

            Console.WriteLine("-----------------------------");

            // the manual way by looping through the array, the needed minimum and maximum values are assigned
            // according to their comparison with the current elements of the given array

            // the minimum and maximum get the first array elements as initial values

            int minimumArrayElement = exampleArray[0];
            int maximumArrayElement = exampleArray[0];

            foreach (int arrayElement in exampleArray)
            {
                if (arrayElement < minimumArrayElement)
                {
                    minimumArrayElement = arrayElement;
                }

                if (arrayElement > maximumArrayElement)
                {
                    maximumArrayElement = arrayElement;
                }
            }

            // output with the placeholder style
            Console.WriteLine("Min = {0}", minimumArrayElement);
            Console.WriteLine("Max = {0}", maximumArrayElement);

            Console.WriteLine("-----------------------------");

            // reinitialization of the minimum and maximum

            minimumArrayElement = int.MaxValue;
            maximumArrayElement = int.MinValue;

            // the longer way via a for loop

            for (int i = 0; i < exampleArray.Length; i++)
            {
                if (exampleArray[i] < minimumArrayElement)
                {
                    minimumArrayElement = exampleArray[i];
                }

                if (exampleArray[i] > maximumArrayElement)
                {
                    maximumArrayElement = exampleArray[i];
                }
            }

            Console.WriteLine("Min = {0}", minimumArrayElement);
            Console.WriteLine("Max = {0}", maximumArrayElement);
        }
    }
}
