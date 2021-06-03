using System;

namespace Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var commandsToFollow = int.Parse(Console.ReadLine());
            var field = new char[matrixSize, matrixSize];
            var playerRow = 0;
            var playerCol = 0;
            var hasWon = false;
            ReadsMatrix(field, ref playerRow, ref playerCol);
            for (int i = 0; i < commandsToFollow; i++)
            {
                var previousPlayerRow = playerRow;
                var previousPlayerCol = playerCol;
                var direction = Console.ReadLine();
                PlayerFutureSpot(ref playerRow, ref playerCol, direction);
                if (InOrOutTheField(playerRow, playerCol, field))
                {
                    if (field[playerRow, playerCol] == 'B')
                    {
                        PlayerFutureSpot(ref playerRow, ref playerCol, direction);
                        if (!(InOrOutTheField(playerRow, playerCol, field)))
                        {
                            OutTheFieldMovement(field, ref playerRow, ref playerCol, direction);
                        }
                    }
                    else if (field[playerRow, playerCol] == 'T')
                    {
                        playerRow = previousPlayerRow;
                        playerCol = previousPlayerCol;
                    }
                    else if (field[playerRow, playerCol] == 'F')
                    {
                        field[previousPlayerRow, previousPlayerCol] = '-';
                        field[playerRow, playerCol] = 'f';
                        hasWon = true;
                        break;
                    }
                }
                else
                {
                    OutTheFieldMovement(field, ref playerRow, ref playerCol, direction);
                    if (field[playerRow, playerCol] == 'B')
                    {
                        PlayerFutureSpot(ref playerRow, ref playerCol, direction);
                        if (!(InOrOutTheField(playerRow, playerCol, field)))
                        {
                            OutTheFieldMovement(field, ref playerRow, ref playerCol, direction);
                        }
                    }
                    else if (field[playerRow, playerCol] == 'T')
                    {
                        playerRow = previousPlayerRow;
                        playerCol = previousPlayerCol;
                    }
                }


                field[previousPlayerRow, previousPlayerCol] = '-';
                field[playerRow, playerCol] = 'f';
            }

            if (hasWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintsMatrix(field);
        }

        private static void OutTheFieldMovement(char[,] field, ref int playerRow, ref int playerCol, string direction)
        {
            if (direction == "up")
            {
                playerRow = field.GetLength(0) - 1;
            }
            else if (direction == "down")
            {
                playerRow = 0;
            }
            else if (direction == "left")
            {
                playerCol = field.GetLength(1) - 1;
            }
            else if (direction == "right")
            {
                playerCol = 0;
            }
        }

        static bool InOrOutTheField(int playerRow, int playerCol, char[,] field)
        {
            if (playerRow >= 0 && playerRow < field.GetLength(0) && playerCol >= 0 && playerCol < field.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void PlayerFutureSpot(ref int playerRow, ref int playerCol, string direction)
        {
            if (direction == "up")
            {
                playerRow--;
            }
            else if (direction == "down")
            {
                playerRow++;
            }
            else if (direction == "left")
            {
                playerCol--;
            }
            else if (direction == "right")
            {
                playerCol++;
            }
        }

        private static void PrintsMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void ReadsMatrix(char[,] field, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = rowData[col];
                    if (field[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
