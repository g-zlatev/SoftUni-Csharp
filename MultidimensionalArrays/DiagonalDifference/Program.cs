using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = input[col];
                }

            }

            int primaryDiagonalSum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            int secondaryDiagonalSum = 0;
            int currCol = matrixSize - 1;
            for (int i = 0; i < matrixSize; i++)
            {
                secondaryDiagonalSum += matrix[i, currCol];
                currCol--;
            }

            int difference = primaryDiagonalSum - secondaryDiagonalSum;
            Console.WriteLine(Math.Abs(difference));

        }
    }
}
