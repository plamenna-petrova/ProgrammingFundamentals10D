using System;

namespace TemperatureConverter
{
    // Methods Exercises Task #5
    public class Program
    {
        static double ConvertFahrenheitToCelsius(double fahrenheitDegrees)
        {
            double celsiusDegreess = (fahrenheitDegrees - 32) * 5 / 9;
            return celsiusDegreess;
        }

        static void Main(string[] args)
        {
            double fathrenheitDegreesInput = double.Parse(Console.ReadLine());
            double celsiusDegreesResult = ConvertFahrenheitToCelsius(fathrenheitDegreesInput);
            Console.WriteLine("{0:F2}", celsiusDegreesResult);
        }
    }
}
