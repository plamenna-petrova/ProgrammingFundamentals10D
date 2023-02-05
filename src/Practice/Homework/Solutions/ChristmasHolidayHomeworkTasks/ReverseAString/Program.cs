using System;

namespace ReverseAString
{
    class Program
    {
        static void ReverseString(string initialString)
        {
            string reversedString = "";

            for (int i = initialString.Length - 1; i >= 0; i--)
            {
                reversedString += initialString[i];
            }

            Console.WriteLine(reversedString);
        }

        static void ReverseStringAlternative(string targetString)
        {
            for (int i = targetString.Length - 1; i >= 0; i--)
            {
                Console.Write($"{targetString[i]}");
            }
        }

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            ReverseString(inputString);

            ReverseStringAlternative(inputString);
        }
    }
}
