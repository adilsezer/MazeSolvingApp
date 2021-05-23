using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MazeSolvingApp
{
    public static class MazeSolver
    {
        private static readonly List<int[]> positionHistory = new List<int[]>();
        private static string logText;
        private const string logFile = "Log.txt";

        public static void SolveMaze(int[,] maze, int xPosition, int yPosition)
        {
            //recursive method to solve maze.
            logText = $"The current maze position has been changed to {xPosition + 1},{yPosition + 1}.";
            PrintMaze(maze);
            Console.WriteLine(logText);

            if (maze.GetLength(0) == xPosition + 1 || maze.GetLength(1) == yPosition + 1 || xPosition == 0 || yPosition == 0)
            {
                //base case that the function will terminate when reached to exit
                logText = $"Application has been successfully reached to exit at coordinates {xPosition + 1}, {yPosition + 1}";
                Console.WriteLine(logText);
                LogHistory();
                Console.WriteLine($"Log.txt file has been created which contains the trail.");
                Environment.Exit(0);
            }

            //positionHistory list is used to return to previous position if there is no path available
            if (!positionHistory.Any(p => p.SequenceEqual(new int[] { xPosition, yPosition })))
            {
                positionHistory.Add(new int[] { xPosition, yPosition });
            }

            maze[xPosition, yPosition] = 2;

            //recursion
            if (maze[(xPosition - 1), yPosition] == 0)
            {
                SolveMaze(maze, xPosition - 1, yPosition);
            }

            if (maze[xPosition, (yPosition + 1)] == 0)
            {
                SolveMaze(maze, xPosition, yPosition = (yPosition + 1));
            }

            if (maze[(xPosition + 1), yPosition] == 0)
            {
                SolveMaze(maze, xPosition + 1, yPosition);
            }

            if (maze[xPosition, (yPosition - 1)] == 0)
            {
                SolveMaze(maze, xPosition, yPosition - 1);
            }

            //return to previous position after checking all possible paths
            if (positionHistory.Count > 1)
            {
                positionHistory.RemoveAt(positionHistory.Count - 1);
                xPosition = positionHistory[positionHistory.Count - 1][0];
                yPosition = positionHistory[positionHistory.Count - 1][1];
                SolveMaze(maze, xPosition, yPosition);
            }
            else
            //there is no possible path and app already in starting point
            {
                logText = $"Application is not able to solve the maze!";
                Console.WriteLine(logText);
                LogHistory();
                Environment.Exit(0);
            }
        }

        private static void PrintMaze(int[,] maze)
        {
            //print updated maze to console
            for (var i = 0; i < maze.GetLength(0); i++)
            {
                for (var j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
            LogHistory();
        }

        private static void LogHistory()
        {
            //writing updated activity to log
            using (var streamWriter = new StreamWriter(logFile, true))
            {
                streamWriter.WriteLine(logText);
            }
        }
    }
}
