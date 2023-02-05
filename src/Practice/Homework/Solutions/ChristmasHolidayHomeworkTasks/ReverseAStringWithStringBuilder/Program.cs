using System;
using System.Text;

namespace ReverseAStringWithStringBuilder
{
    class Program
    {
        static string ReverseString(string stringToReverse)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(stringToReverse[i]);
            }

            string result = stringBuilder.ToString();

            return result;
        }

        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();

            Console.WriteLine(ReverseString(stringInput));
        }
    }
}
