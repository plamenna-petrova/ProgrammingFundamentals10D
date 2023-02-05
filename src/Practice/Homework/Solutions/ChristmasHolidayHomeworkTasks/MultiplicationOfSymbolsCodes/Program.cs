using System;
using System.Linq;

namespace MultiplicationOfSymbolsCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split().ToArray();

            string firstString = inputStrings[0];
            string secondString = inputStrings[1];

            int minLength = 1;
            int sum = 0;

            if (firstString.Length > secondString.Length)
            {
                minLength = secondString.Length;

                for (int i = minLength; i < firstString.Length; i++)
                {
                    sum += (int) firstString[i];
                }
            }
            else
            {
                minLength = firstString.Length;

                for (int i = minLength; i < secondString.Length; i++)
                {
                    sum += (int) secondString[i];
                }
            }

            for (int i = 0; i < minLength; i++)
            {
                int firstStringCharCode = (int) firstString[i];
                int secondStringCharCode = (int) secondString[i];

                sum += firstStringCharCode * secondStringCharCode;
            }

            Console.WriteLine(sum);
        }
    }
}
