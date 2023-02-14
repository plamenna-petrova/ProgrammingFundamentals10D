
using System;
using System.Linq;

namespace Exercise_07_02_2022
{
    public class Program
    {
        static int[,] FillMatrixElements()
        {
            Console.WriteLine("Enter matrix rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter matrix cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"matrix[{row}, {col}] = ");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        static int[,] FillMatrixElementsWithRowsAndCols(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            return matrix;
        }

        static void DisplayMatrixElements(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 5}", matrix[row, col]);
                }

                Console.WriteLine();
            }

            //Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // hardcoded 

            int[,] twoDimensionalArray = new int[,]
            {
                { 10, 15, 22, 27, 5 },
                { 6, 17, 28, 9, 11},
                { 13, 45, 5, 2, 12 }
            };

            DisplayMatrixElements(twoDimensionalArray);

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = FillMatrixElementsWithRowsAndCols(rows, cols);

            DisplayMatrixElements(matrix);
        }
    }
}
