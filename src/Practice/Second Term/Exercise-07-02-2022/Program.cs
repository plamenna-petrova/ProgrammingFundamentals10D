using System;
using System.Linq;

namespace Exercise_07_02_2022
{
    public class Program
    {
        static int[,,] FillThreeDimensionalArrayElements()
        {
            Console.WriteLine("Enter X layer size: ");
            int xLayerSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y layer size: ");
            int yLayerSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Z layer size: ");
            int zLayerSize = int.Parse(Console.ReadLine());

            int[,,] threeDimensionalArray = new int[xLayerSize, yLayerSize, zLayerSize];

            for (int x = 0; x < xLayerSize; x++)
            {
                for (int y = 0; y < yLayerSize; y++)
                {
                    for (int z = 0; z < zLayerSize; z++)
                    {
                        Console.Write($"3D Array: [{x}, {y}, {z}] = ");
                        threeDimensionalArray[x, y, z] = int.Parse(Console.ReadLine());
                    }
                }
            }

            return threeDimensionalArray;
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

            int[,] matrix = FillMatrixElements(rows, cols);

            DisplayMatrixElements(matrix);
        }
    }
}
