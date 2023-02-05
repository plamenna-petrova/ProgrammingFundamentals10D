using System;

namespace MultiplicationOfEvensByOdds
{
    // Debugging and Code fixing - Task #1
    public class Program
    {
        static int GetMultiplicationOfEvensAndOdds(int number)
        {
            int evensSum = GetSumOfEvenDigits(number);
            int oddsSum = GetSumOfOddDigits(number);
            return evensSum * oddsSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                }

                number /= 10;
            }

            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sumOfOddDigits += lastDigit;
                }

                number /= 10;
            }

            return sumOfOddDigits;
        }

        // logic moved into one method
        static int GetMultiplicationOfEvensAndOddsAlternative(int number)
        {
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                }
                else
                {
                    sumOfOddDigits += lastDigit;
                }
            }

            return sumOfEvenDigits * sumOfOddDigits;
        }

        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int numberInputAbsoluteValue = Math.Abs(numberInput);
            int multiplicationOfEvensAndOdds = GetMultiplicationOfEvensAndOdds(numberInputAbsoluteValue);
            Console.WriteLine(multiplicationOfEvensAndOdds);

            Console.WriteLine(GetMultiplicationOfEvensAndOddsAlternative(numberInputAbsoluteValue));
        }
    }
}
