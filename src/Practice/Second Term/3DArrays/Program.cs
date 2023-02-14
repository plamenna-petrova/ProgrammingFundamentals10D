using System;

namespace _3DArrays
{
    public class Program
    {
        static int[,,] Fill3DArrayElements(int numberOfMatrixes, int numberOfRows, int numberOfCols)
        {
            int[,,] threeDimensionalArray = new int[numberOfMatrixes, numberOfRows, numberOfCols];

            for (int x = 0; x < numberOfMatrixes; x++)
            {
                for (int y = 0; y < numberOfRows; y++)
                {
                    for (int z = 0; z < numberOfCols; z++)
                    {
                        Console.Write($"3D Array: [{x}, {y}, {z}] = ");
                        threeDimensionalArray[x, y, z] = int.Parse(Console.ReadLine());
                    }
                }
            }

            return threeDimensionalArray;
        }

        static void Display3DArrayElements(int[,,] threeDimensionalArray)
        {
            for (int x = 0; x < threeDimensionalArray.GetLength(0); x++)
            {
                for (int y = 0; y < threeDimensionalArray.GetLength(1); y++)
                {
                    for (int z = 0; z < threeDimensionalArray.GetLength(2); z++)
                    {
                        Console.Write("{0, 5}", threeDimensionalArray[x, y, z]);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Display3DArrayElements(string[,,] threeDimensionalArray)
        {
            for (int x = 0; x < threeDimensionalArray.GetLength(0); x++)
            {
                for (int y = 0; y < threeDimensionalArray.GetLength(1); y++)
                {
                    for (int z = 0; z < threeDimensionalArray.GetLength(2); z++)
                    {
                        Console.Write($"matrix[{x}]row[{y}]col[{z}] = {threeDimensionalArray[x, y, z]}  ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // 3D example

            int[,,] array3D = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

            // 4D example

            int[,,,] arrays4D = new int[1, 2, 2, 3] 
            {
                {
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 }
                    },
                    {
                        { 7, 8, 9 },
                        { 10, 11, 12 }
                    }
                }
            };

            Display3DArrayElements(array3D);

            //Console.WriteLine("Enter number of matrixes: ");
            //int numberOfMatrixes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number of rows for each matrix: ");
            //int numberOrRows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number of cols for each matrix: ");
            //int numberOfCols = int.Parse(Console.ReadLine());

            // TODO use the fill method to make your own 3D Array and then display its elements

            int[,,] simple3DArray = new int[1, 3, 2]
            {
                 {
                    { 3, 5 },
                    { 3, 5 },
                    { 3, 5 }
                 },
            };

            string[,,] rubiksCubeArray = new string[6, 3, 3]
            {
                {
                    { "blue", "blue", "blue" },
                    { "blue", "blue", "blue" },
                    { "blue", "blue", "blue" },
                },
                {
                    { "green", "green", "green" },
                    { "green", "green", "green" },
                    { "green", "green", "green" }
                },
                {
                    { "yellow", "yellow", "yellow" },
                    { "yellow", "yellow", "yellow" },
                    { "yellow", "yellow", "yellow" }
                },
                {
                    { "white", "white", "white" },
                    { "white", "white", "white" },
                    { "white", "white", "white" }
                },
                {
                    { "orange", "orange", "orange" },
                    { "orange", "orange", "orange" },
                    { "orange", "orange", "orange" }
                },
                {
                    { "red", "red", "red" },
                    { "red", "red", "red" },
                    { "red", "red", "red" }
                }
            };

            // the Rubik's cube array consists of 6 matrixes, each represented by 3 rows and 3 columns

            Display3DArrayElements(rubiksCubeArray);
        }
    }
}
