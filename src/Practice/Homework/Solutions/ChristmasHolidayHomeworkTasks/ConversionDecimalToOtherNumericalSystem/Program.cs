using System;
using System.Linq;

namespace ConversionDecimalToOtherNumericalSystem
{
    public class Program
    {
        static string GetNewNumberInNthSystem(int numeralSystem, int number)
        {
            string newNumber = "";

            while (number != 0)
            {
                int remainder = number % numeralSystem;
                newNumber += remainder;
                number /= numeralSystem;
            }

            // 1) reverse the number

            var reversedNumber = newNumber.Reverse();

            // 2) the new number value must be joined by an empty string with the reversed number

            newNumber = string.Join(string.Empty, reversedNumber);

            return newNumber;
        }

        static void Main(string[] args)
        {
            string[] conversionInput = Console.ReadLine().Split().ToArray();

            int numeralSystemInput = int.Parse(conversionInput[0]);
            int number = int.Parse(conversionInput[1]);

            Console.WriteLine(GetNewNumberInNthSystem(numeralSystemInput, number));
        }
    }
}
