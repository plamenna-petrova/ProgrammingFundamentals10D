using System;

namespace SignForWholeNumber
{
    // Methods Exercises Task #2
    public class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }

        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            PrintSign(numberInput);
        }
    }
}
