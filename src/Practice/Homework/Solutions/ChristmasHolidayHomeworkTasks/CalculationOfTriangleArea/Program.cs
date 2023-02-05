using System;

namespace CalculationOfTriangleArea
{
    // Methods Exercises Task #6
    public class Program
    {
        static double CalculateTriangleArea(double width, double height)
        {
            double triangleArea = width * height / 2;
            return triangleArea;
        }

        static void Main(string[] args)
        {
            double triangleWidth = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = CalculateTriangleArea(triangleWidth, triangleHeight);
            Console.WriteLine(triangleArea);
        }
    }
}
