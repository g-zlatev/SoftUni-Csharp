using System;

namespace SpaceStationEstablishment
{
    class Program
    {
        private const int MIN_STAR_POW_NEEDED = 50;

        private static char[][] galaxy;
        private static int playerRow;
        private static int playerCol;
        private static int collectedEnergy;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            FillGalaxy(n);

            while (collectedEnergy < MIN_STAR_POW_NEEDED)
            {
                string direction = Console.ReadLine();

                int nextRow = playerRow;
                int nextCol = playerCol;

                DetermineNextCoordinates(direction, ref nextRow, ref nextCol);

                bool isOutside = CheckIfPlayerIsOutside(n, nextRow, nextCol);

                if (isOutside)
                {
                    galaxy[playerRow][playerCol] = '-';
                    break;
                }

                ProceedMove(n, nextRow, nextCol);

            }

            PrintOutPut(n);

        }

        private static void PrintOutPut(int n)
        {
            if (collectedEnergy >= MIN_STAR_POW_NEEDED)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {collectedEnergy}");

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join("", galaxy[row]));
            }
        }

        private static bool CheckIfPlayerIsOutside(int n, int nextRow, int nextCol)
        {
            return nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n;
        }

        private static void DetermineNextCoordinates(string direction, ref int nextRow, ref int nextCol)
        {
            if (direction == "up")
            {
                nextRow = playerRow - 1;
                nextCol = playerCol;

            }
            else if (direction == "down")
            {
                nextRow = playerRow + 1;
                nextCol = playerCol;

            }
            else if (direction == "left")
            {
                nextRow = playerRow;
                nextCol = playerCol - 1;

            }
            else if (direction == "right")
            {
                nextRow = playerRow;
                nextCol = playerCol + 1;

            }
        }

        private static void ProceedMove(int n, int nextRow, int nextCol)
        {
            char nextSymbol = galaxy[nextRow][nextCol];

            if (char.IsDigit(nextSymbol))
            {
                int starEnergy = (int)nextSymbol - 48;

                collectedEnergy += starEnergy;
            }
            else if (nextSymbol == 'O')
            {
                TravelThroughBlackHoles(n, ref nextRow, ref nextCol);
            }

            galaxy[nextRow][nextCol] = 'S';
            galaxy[playerRow][playerCol] = '-';

            playerRow = nextRow;
            playerCol = nextCol;
        }

        private static void TravelThroughBlackHoles(int n, ref int nextRow, ref int nextCol)
        {
            galaxy[nextRow][nextCol] = '-';

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char iterSymbol = galaxy[row][col];

                    if (iterSymbol == 'O')
                    {
                        nextRow = row;
                        nextCol = col;
                    }
                }
            }
        }

        private static void FillGalaxy(int n)
        {
            galaxy = new char[n][];

            bool found = false;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                if (!found)
                {
                    for (int col = 0; col < currentRow.Length; col++)
                    {
                        if (currentRow[col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;

                            found = true;
                            break;
                        }

                    }
                }

                galaxy[row] = currentRow;
            }
        }
    }
}
