using System;

namespace DrawingAFilledSquare
{
    // Methods Exercises Task #4
    public class Program
    {
        static void PrintHeaderOrFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void Main(string[] args)
        {
            int filledSquareSize = int.Parse(Console.ReadLine());
            PrintHeaderOrFooterRow(filledSquareSize);
            PrintMiddleRow(filledSquareSize);
            PrintHeaderOrFooterRow(filledSquareSize);
        }
    }
}
