using System;

namespace TrianglePrinting
{
    // Methods Exercises Task #3
    public class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            PrintTriangle(triangleSize);
        }
    }
}
