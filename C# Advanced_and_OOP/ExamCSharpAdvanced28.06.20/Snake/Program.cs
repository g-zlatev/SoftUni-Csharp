using System;
using System.Linq;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int snakeRow = -1;
            int snakeCol = -1;
            bool snakeNotFount = true;

            int foodQuantity = 0;
            bool outOfBounds = false;

            InitializeMatrix(n, matrix, ref snakeRow, ref snakeCol, ref snakeNotFount);

            string command;
            while (foodQuantity <= 10 || !outOfBounds)
            {
                command = Console.ReadLine();

                if (command == "up")
                {
                    if (snakeRow - 1 >= 0)
                    {
                        matrix[snakeRow, snakeCol] = '.';

                        snakeRow--;
                        char symbol = matrix[snakeRow, snakeCol];

                        if (symbol == '*')
                        {
                            foodQuantity++;
                        }

                        else if (symbol == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        matrix[snakeRow, snakeCol] = 'S';

                    }
                    else
                    {
                        outOfBounds = true;
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }

                }

                else if (command == "down")
                {
                    if (snakeRow + 1 < n)
                    {
                        snakeRow++;
                        char symbol = matrix[snakeRow, snakeCol];

                        if (symbol == '*')
                        {
                            foodQuantity++;
                        }

                        matrix[snakeRow - 1, snakeCol] = '.';

                        if (symbol == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        matrix[snakeRow, snakeCol] = 'S';

                    }
                    else
                    {
                        outOfBounds = true;
                        matrix[snakeRow, snakeCol] = '.'; ;
                        break;
                    }

                }  //check!

                else if (command == "left")
                {
                    if (snakeCol - 1 >= 0)
                    {
                        snakeCol--;
                        char symbol = matrix[snakeRow, snakeCol];

                        if (symbol == '*')
                        {
                            foodQuantity++;
                        }

                        matrix[snakeRow, snakeCol + 1] = '.';

                        if (symbol == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        matrix[snakeRow, snakeCol] = 'S';

                    }
                    else
                    {
                        outOfBounds = true;
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }

                } //check!

                else if (command == "right")
                {
                    if (snakeCol + 1 < n)
                    {
                        snakeCol++;
                        char symbol = matrix[snakeRow, snakeCol];

                        if (symbol == '*')
                        {
                            foodQuantity++;
                        }

                        matrix[snakeRow, snakeCol - 1] = '.';

                        if (symbol == 'B')
                        {
                            matrix[snakeRow, snakeCol] = '.';

                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        matrix[snakeRow, snakeCol] = 'S';

                    }
                    else
                    {
                        outOfBounds = true;
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }

                } //check!

                if (foodQuantity == 10)
                {
                    break;
                }

            }

            if (outOfBounds)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

        private static void InitializeMatrix(int n, char[,] matrix, ref int snakeRow, ref int snakeCol, ref bool snakeNotFount)
        {
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (snakeNotFount)
                    {
                        if (matrix[row, col] == 'S')
                        {
                            snakeRow = row;
                            snakeCol = col;
                            snakeNotFount = false;
                            break;
                        }

                    }

                }
            }
        }
    }
}
