using System;

namespace TheGreaterThanTwoValues
{
    // Methods Exercises Task #8
    public class Program
    {
        static int GetMax(int firstToCompare, int secondToCompare)
        {
            if (firstToCompare >= secondToCompare)
            {
                return firstToCompare;
            }

            return secondToCompare;
        }

        static char GetMax(char firstToCompare, char secondToCompare)
        {
            if (firstToCompare >= secondToCompare)
            {
                return firstToCompare;
            }

            return secondToCompare;
        }

        static string GetMax(string firstToCompare, string secondToCompare)
        {
            if (firstToCompare.CompareTo(secondToCompare) >= 0)
            {
                return firstToCompare;
            }

            return secondToCompare;
        }

        static void Main(string[] args)
        {
            string typeForComparison = Console.ReadLine();

            switch (typeForComparison)
            {
                case "int":
                    int firstIntegerValue = int.Parse(Console.ReadLine());
                    int secondIntegerValue = int.Parse(Console.ReadLine());
                    int maxInteger = GetMax(firstIntegerValue, secondIntegerValue);
                    Console.WriteLine(maxInteger);
                    break;
                case "char":
                    char firstCharValue = char.Parse(Console.ReadLine());
                    char secondCharValue = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(firstCharValue, secondCharValue);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string firstStringValue = Console.ReadLine();
                    string secondStringValue = Console.ReadLine();
                    string maxStringValue = GetMax(firstStringValue, secondStringValue);
                    Console.WriteLine(maxStringValue);
                    break;
            }
        }
    }
}
