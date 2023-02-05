using System;

namespace UnicodeSymbols
{
    class Program
    {
        static string GetEscapeSequence(char singleCharacter)
        {
            return "\\u" + ((int) singleCharacter).ToString("X4").ToLower();
        }

        static void ConvertStringToUnicodeRepresentation(string targetString)
        {
            string resultingUnicodeRepresentationString = "";

            for (int i = 0; i < targetString.Length; i++)
            {
                resultingUnicodeRepresentationString += GetEscapeSequence(targetString[i]);
            }

            Console.WriteLine(resultingUnicodeRepresentationString);
        }

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            ConvertStringToUnicodeRepresentation(inputString);
        }
    }
}
