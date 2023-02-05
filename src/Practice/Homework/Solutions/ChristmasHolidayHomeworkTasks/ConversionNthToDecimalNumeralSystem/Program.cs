using System;
using System.Linq;

namespace ConversionNthToDecimalNumeralSystem
{
    public class Program
    {
        static int GetNumberInDecimalSystem(int numeralSystem, int number)
        {
            int index = 0;
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10 * (int)Math.Pow(numeralSystem, index);
                number /= 10;
                index++;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            string[] conversionInput = Console.ReadLine().Split().ToArray();
            int numeralSystem = int.Parse(conversionInput[0]);
            int number = int.Parse(conversionInput[1]);

            Console.WriteLine(GetNumberInDecimalSystem(numeralSystem, number));
        }
    }
}
