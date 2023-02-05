using System;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static bool CheckForPalindrome(string stringToCheck)
        {
            int length = stringToCheck.Length;

            bool isPalindrome = true;

            for (int i = 0; i < length / 2; i++)
            {
                if (stringToCheck[i] != stringToCheck[length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Console.WriteLine(CheckForPalindrome(inputString));

            //Console.WriteLine(inputString.SequenceEqual(inputString.Reverse()));
        }
    }
}
