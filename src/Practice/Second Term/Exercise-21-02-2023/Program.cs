using System;
using System.Linq;

namespace Exercise_21_02_2023
{
    public class Program
    {
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
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrixToFindColsMinimum = FillMatrixElementsWithRowsAndCols(rows, cols);
            int[] colsMinimums = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                int minimum = matrixToFindColsMinimum[0, col];

                for (int row = 0; row < rows; row++)
                {
                    if (matrixToFindColsMinimum[row, col] < minimum)
                    {
                        minimum = matrixToFindColsMinimum[row, col];
                    }
                }

                colsMinimums[col] = minimum;
            }

            DisplayMatrixElements(matrixToFindColsMinimum);

            foreach (var minimum in colsMinimums)
            {
                Console.Write("{0, 5}", minimum);
            }
        }
    }
}
