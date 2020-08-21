using System;

namespace Bee
{
    class Program
    {
        private static char[][] territory;
        private static int beeRow;
        private static int beeCol;
        private static int polinatedFlowers;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FillTerritory(n);

            string command;

            bool isOutside = false;

            while ((command = Console.ReadLine()) != "End")
            {
                int nextRow = beeRow;
                int nextCol = beeCol;

                DetermineNextCoordinates(command, ref nextRow, ref nextCol);

                isOutside = CheckIfBeeIsOutside(n, nextRow, nextCol);

                if (isOutside)
                {
                    territory[beeRow][beeCol] = '.';
                    break;
                }

                char nextSymbol = territory[nextRow][nextCol];

                if (nextSymbol == 'f')
                {
                    polinatedFlowers++;
                }
                else if (nextSymbol == 'O')
                {
                    territory[nextRow][nextCol] = 'B';
                    territory[beeRow][beeCol] = '.';

                    beeRow = nextRow;
                    beeCol = nextCol;

                    if (command == "up")
                    {
                        nextRow = beeRow - 1;
                        nextCol = beeCol;

                    }
                    else if (command == "down")
                    {
                        nextRow = beeRow + 1;
                        nextCol = beeCol;

                    }
                    else if (command == "left")
                    {
                        nextRow = beeRow;
                        nextCol = beeCol - 1;

                    }
                    else if (command == "right")
                    {
                        nextRow = beeRow;
                        nextCol = beeCol + 1;

                    }

                    if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n)
                    {
                        isOutside = true;
                        break;
                    }

                    char nextTurn = territory[nextRow][nextCol];

                    if (nextTurn == 'f')
                    {
                        polinatedFlowers++;
                    }

                }

                territory[nextRow][nextCol] = 'B';
                territory[beeRow][beeCol] = '.';

                beeRow = nextRow;
                beeCol = nextCol;

            }

            if (isOutside)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (polinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join("", territory[row]));
            }

        }


        private static bool CheckIfBeeIsOutside(int n, int nextRow, int nextCol)
        {
            return nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n;
        }

        private static void DetermineNextCoordinates(string direction, ref int nextRow, ref int nextCol)
        {
            if (direction == "up")
            {
                nextRow = beeRow - 1;
                nextCol = beeCol;

            }
            else if (direction == "down")
            {
                nextRow = beeRow + 1;
                nextCol = beeCol;

            }
            else if (direction == "left")
            {
                nextRow = beeRow;
                nextCol = beeCol - 1;

            }
            else if (direction == "right")
            {
                nextRow = beeRow;
                nextCol = beeCol + 1;

            }
        }

        private static void FillTerritory(int n)
        {
            territory = new char[n][];

            bool found = false;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                if (!found)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'B')
                        {
                            beeRow = row;
                            beeCol = col;

                            found = true;
                            break;
                        }

                    }
                }

                territory[row] = currentRow;

            }
        }
    }
}
