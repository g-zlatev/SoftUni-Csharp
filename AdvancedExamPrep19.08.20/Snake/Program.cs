using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            //int food = 0;

            bool isFull = false;
            bool isOutOfBounds = false;

            Dictionary<string, List<int>> positions = new Dictionary<string, List<int>>
            {
                {"snake", new List<int>()}, {"burrow", new List<int>()}, {"food", new List<int>()}
            };


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'S')
                    {
                        positions["snake"].Add(row);
                        positions["snake"].Add(col);
                    }

                    if (input[col] == 'B')
                    {
                        positions["burrow"].Add(row);
                        positions["burrow"].Add(col);
                    }

                    if (input[col] == '*')
                    {
                        positions["food"].Add(row);
                        positions["food"].Add(col);
                    }
                }
            }

            string command;

            while (!isFull || !isOutOfBounds)
            {
                command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[positions["snake"][0], positions["snake"][1]] = '.';


                }


            }

        }
    }
}
