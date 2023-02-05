using System;

namespace PowerRaising
{
    // Methods Exercises Task #7
    public class Program
    {
        static double RaiseToPower(double number, int power)
        {
            // the quick way
            //double result = Math.Pow(number, power);

            // by using a for loop - alternative
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        static void Main(string[] args)
        {
            double numberToRaise = double.Parse(Console.ReadLine());
            int powerForRaising = int.Parse(Console.ReadLine());
            double raisedNumber = RaiseToPower(numberToRaise, powerForRaising);
            Console.WriteLine(raisedNumber);
        }
    }
}
