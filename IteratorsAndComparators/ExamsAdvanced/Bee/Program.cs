using System;
using System.Collections.Generic;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSizes, matrixSizes];
            var beeCurLocation = new List<int>();
            ReadsMatrix(matrix, beeCurLocation);
            var minFlowersToCollect = 5;
            var flowersCollected = 0;
            var isOut = false;
            var direction = Console.ReadLine();
            while (direction != "End")
            {
                var nextRowPosition = beeCurLocation[0];
                var nextColPosition = beeCurLocation[1];


                switch (direction)
                {
                    case "up":
                        nextRowPosition--;
                        break;
                    case "down":
                        nextRowPosition++;
                        break;
                    case "left":
                        nextColPosition--;
                        break;
                    case "right":
                        nextColPosition++;
                        break;
                }

                matrix[beeCurLocation[0], beeCurLocation[1]] = '.';
                if (IsValid(matrix, nextRowPosition, nextColPosition))
                {

                    if (FlowerOrNot(matrix, ref flowersCollected, ref nextRowPosition, nextColPosition))
                    {
                        flowersCollected++;
                    }
                    else if (matrix[nextRowPosition, nextColPosition] == 'O')
                    {
                        matrix[nextRowPosition, nextColPosition] = '.';
                        beeCurLocation[0] = nextRowPosition;
                        beeCurLocation[1] = nextColPosition;
                        continue;
                    }

                    beeCurLocation[0] = nextRowPosition;
                    beeCurLocation[1] = nextColPosition;
                    matrix[nextRowPosition, nextColPosition] = 'B';
                }
                else
                {
                    isOut = true;
                    break;
                }

                direction = Console.ReadLine();
            }

            if (isOut)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (flowersCollected >= minFlowersToCollect)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCollected} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {minFlowersToCollect - flowersCollected} flowers more");
            }

            PrintsMatrix(matrix);
        }

        private static void AddsAFlower(char[,] matrix, ref int flowersCollected, ref int nextRowPosition, int nextColPosition)
        {
            if (FlowerOrNot(matrix, ref flowersCollected, ref nextRowPosition, nextColPosition))
            {
                flowersCollected++;
            }
        }

        static bool FlowerOrNot(char[,] matrix, ref int flowersCollected, ref int nextRowPosition, int nextColPosition)
        {
            if (matrix[nextRowPosition, nextColPosition] == 'f')
            {
                return true;
            }

            return false;

        }

        static bool IsValid(char[,] matrix, int nextRow, int nextCol)
        {
            if (nextRow >= 0 && nextRow < matrix.GetLongLength(0) && nextCol >= 0 && nextCol < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        private static void PrintsMatrix(char[,] matrix)
        {
            for (int ROW = 0; ROW < matrix.GetLength(0); ROW++)
            {
                for (int COL = 0; COL < matrix.GetLength(1); COL++)
                {
                    Console.Write(matrix[ROW, COL]);
                }

                Console.WriteLine();
            }
        }

        private static void ReadsMatrix(char[,] matrix, List<int> beeCurLocation)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row, col] == 'B')
                    {
                        beeCurLocation.Add(row);
                        beeCurLocation.Add(col);
                    }
                }
            }
        }
    }
}
