using System;

namespace MazeSolvingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read txt file and write maze to console
            MazeReader.ReadMaze();
            if (MazeReader.readerStatus == false)
            {
                //Something is wrong in maze file. Either dimensions doesn'est match with first line parameters or maze is not properly written
                Console.WriteLine($"Cannot properly read maze from maze file! Please fix maze file and try again!");
                Environment.Exit(0);
            }

            //Verify start position as default or user input. Checks if wall is present in specified coordinates or given coordinates is suitable to start
            var verifiedStartPoint = PositionVerifier.VerifyPosition(MazeReader.maze, MazeReader.startX, MazeReader.startY);
            if (verifiedStartPoint.Item1 == false)
            {
                Console.WriteLine($"Quited application as starting coordinates {verifiedStartPoint.Item2}, {verifiedStartPoint.Item3} is not valid.\n" +
                    $"Please input another maze position or update maze file when running the application again with the default start position as 2");
            }

            //Logic to solve the maze
            MazeSolver.SolveMaze(verifiedStartPoint.Item2, verifiedStartPoint.Item3, verifiedStartPoint.Item4);
        }
    }
}