using System;

namespace PalindromeOptimizedSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = 0;
            double num = word.Length / 2;

            bool isPalindrome = false;

            for (int i = 0; i < num; i++)
            {
                if (word[i] == word[(word.Length - 1) - i])
                {
                    counter++;
                }
            }

            if (counter == num)
            {
                isPalindrome = true;
            }

            Console.WriteLine(isPalindrome);
        }
    }
}
