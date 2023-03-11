using System;

namespace Exercise_07_03_2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];

            int[][] hardcodedJaggedArray = new int[][]
            {
                new int[] { 2, 8, 4, 6 },
                new int[] { 3, 6 },
                new int[] { 10, 20, 40 }
            };

            jaggedArray[0][3] = 5;

            hardcodedJaggedArray[0][3] = 9;
            hardcodedJaggedArray[1][1] = 7;
            hardcodedJaggedArray[2][0] = 11;

            foreach (var array in hardcodedJaggedArray)
            {
                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }

            int[][,] jaggedTwoDimensionalArray = new int[2][,];

            jaggedTwoDimensionalArray[0] = new int[,]
            {
                { 5, 3 },
                { 2, 9 }
            };
            jaggedTwoDimensionalArray[1] = new int[,]
            {
                { 3, 5, 2 },
                { 8, 2, 9 }
            };

            jaggedTwoDimensionalArray[0][0, 1] = 6;
            jaggedTwoDimensionalArray[1][1, 2] = 8;

            foreach (var twoDimensionalArray in jaggedTwoDimensionalArray)
            {
                for (int row = 0; row < twoDimensionalArray.GetLength(0); row++)
                {
                    for (int col = 0; col < twoDimensionalArray.GetLength(1); col++)
                    {
                        Console.Write("{0, 5}", twoDimensionalArray[row, col]);
                    }

                    Console.WriteLine();
                }
            }

            // The Pascal Triangle

            int height = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[height][];

            for (int row = 0; row < height; row++)
            {
                pascalTriangle[row] = new long[row + 1];
            }

            pascalTriangle[0][0] = 1;

            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    pascalTriangle[row + 1][col] += pascalTriangle[row][col];
                    pascalTriangle[row + 1][col + 1] += pascalTriangle[row][col];
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int k = 1; k < height - i; k++)
                {
                    Console.Write("   "); 
                }

                long[] row = pascalTriangle[i];

                foreach (var element in row)
                {
                    Console.Write("{0}     ", element);
                }

                Console.WriteLine();
            }
        }
    }
}
