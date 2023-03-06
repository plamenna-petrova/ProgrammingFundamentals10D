using System;
using System.Collections.Generic;
using System.Linq;

namespace LotteryTicket
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

        static void Main(string[] args)
        {
            List<int> matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int rows = matrixDimensions.ElementAt(0);
            int cols = matrixDimensions.ElementAt(1);

            int[,] lotteryMatrix = FillMatrixElementsWithRowsAndCols(rows, cols);

            /*
                1 2 2
                3 5 6
                8 8 9
            */

            int dimension = rows = cols;

            int principalDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int sumOfElementsOverPrincipalDiagonal = 0;
            int sumOfElementsUnderPrincipalDiagonal = 0;
            int sumOfEvenElementsOnPrincipalDiagonal = 0;
            int sumOfEvenElementsOnOuterRows = 0;
            int sumOfOddElementsOnOuterCols = 0;

            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension; col++)
                {
                    // Condition for elements that lie on the principal diagonal
                    if (row == col)
                    {
                        principalDiagonalSum += lotteryMatrix[row, col];

                        if (lotteryMatrix[row, col] % 2 == 0)
                        {
                            sumOfEvenElementsOnPrincipalDiagonal += lotteryMatrix[row, col];
                        }
                    }

                    // Condition for elements that lie on the secondary diagonal
                    if ((row + col) == (dimension - 1))
                    {
                        secondaryDiagonalSum += lotteryMatrix[row, col];
                    }

                    // Condition for elements that lie over the principal diagonal
                    if (row < col)
                    {
                        sumOfElementsOverPrincipalDiagonal += lotteryMatrix[row, col];
                    }

                    // Conditiion for elements that lie under the principal diagonal
                    if (row > col)
                    {
                        sumOfElementsUnderPrincipalDiagonal += lotteryMatrix[row, col];
                    }

                    if (row == 0 || row == dimension - 1)
                    {
                        if (lotteryMatrix[row, col] % 2 == 0)
                        {
                            sumOfEvenElementsOnOuterRows += lotteryMatrix[row, col];
                        }
                    }

                    if (col == 0 || col == dimension - 1)
                    {
                        if (lotteryMatrix[row, col] % 2 != 0)
                        {
                            sumOfOddElementsOnOuterCols += lotteryMatrix[row, col];
                        }
                    }
                }
            }

            if (principalDiagonalSum == secondaryDiagonalSum &&
                sumOfElementsOverPrincipalDiagonal % 2 == 0 &&
                sumOfElementsUnderPrincipalDiagonal % 2 != 0
            )
            {
                double lotteryAverageSum =
                    (sumOfElementsUnderPrincipalDiagonal +
                    sumOfEvenElementsOnPrincipalDiagonal +
                    sumOfEvenElementsOnOuterRows +
                    sumOfOddElementsOnOuterCols) / 4;
                Console.WriteLine("YES");
                Console.WriteLine($"The amount of money won is: {Math.Round(lotteryAverageSum, 2):F2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
