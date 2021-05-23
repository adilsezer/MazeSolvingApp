using System;
namespace MazeSolvingApp
{
    public static class PositionVerifier
    {
        //returning tuple with verifystatus, maze, X and Y position
        public static Tuple<bool, int[,], int, int> VerifyPosition(int[,] maze, int startX, int startY)
        {
            bool positionVerified = false;

            //loop until position verified or user press Q to Quit the app
            while (!positionVerified)
            {
                Console.WriteLine($"Starting position is currently set to {startX + 1},{startY + 1}.");
                Console.WriteLine("Please press 0 to keep default position, press 1 to change position, or press Q to quit application");
                string userInput = Console.ReadLine();

                //quit
                if (userInput.ToUpper() == "Q")
                {
                    Console.WriteLine("Quited application as per user input");
                    Environment.Exit(0);
                }

                //change start position
                else if (userInput == "1")
                {
                    maze[startX, startY] = 0;
                    Console.WriteLine("Please enter X and Y coordinates");

                    Console.WriteLine("X: ");
                    string inputXPos = Console.ReadLine();
                    int parsedXPos;

                    if (!int.TryParse(inputXPos, out parsedXPos) || parsedXPos < 1 || parsedXPos > maze.GetLength(0))
                    {
                        Console.WriteLine("Wrong X position entered!");
                        continue;
                    }

                    Console.WriteLine("Y: ");
                    string inputYPos = Console.ReadLine();
                    int parsedYpos;

                    if (!int.TryParse(inputYPos, out parsedYpos) || parsedYpos < 1 || parsedYpos > maze.GetLength(1))
                    {
                        Console.WriteLine("Wrong Y position entered!");
                        continue;
                    }

                    if (maze[parsedXPos - 1, parsedYpos - 1] == 1)
                    {
                        Console.WriteLine("There is a wall in the chosen position, please choose another one!");
                        continue;
                    }

                    startX = parsedXPos - 1;
                    startY = parsedYpos - 1;
                    maze[startX, startY] = 2;

                    positionVerified = true;
                }

                //keep default position written as 2 in RPAMaze.txt file
                else if (userInput == "0")
                {
                    positionVerified = startX >= 1 && startX <= maze.GetLength(0) && startY >= 1 && startY <= maze.GetLength(1) ? true : false;
                    break;
                }

                //user pressed a different key, ask again
                else
                {
                    Console.WriteLine($"Wrong key pressed!");
                    continue;
                }
            }

            //returning variables
            return new Tuple<bool, int[,], int, int>(positionVerified, maze, startX, startY);
        }
    }
}
