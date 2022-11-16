using System;
using System.Linq;

namespace Exercise_20_10_2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maximumCountOfIdenticalElements = 0;

            int firstElementWithMaximumIdenticalOccurrences = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int currentCountOfIdenticalElements = 0;

                for (int j = 0; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] == numbersArray[j])
                    {
                        currentCountOfIdenticalElements++;
                    }
                }

                if (currentCountOfIdenticalElements > maximumCountOfIdenticalElements)
                {
                    maximumCountOfIdenticalElements = currentCountOfIdenticalElements;
                    firstElementWithMaximumIdenticalOccurrences = numbersArray[i];
                }
            }

            Console.WriteLine(firstElementWithMaximumIdenticalOccurrences);
        }
    }
}
