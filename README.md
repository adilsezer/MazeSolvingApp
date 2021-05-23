# MazeSolvingApp
C# console application to find the exit route in 2D array maze

Application takes input parameters from Maze.txt text file.
First line contains maze high (10) and width (10). Next ten lines are maze representation as two- dimensional array. Wall tiles are marked with 1, path tiles are marked with 0 and start position is marked with 2.

## Application Features:
* Application works correctly with any size of maze and with any start positions
* When application starts, user can define new start position
* It prints maze from text file into console
* Moves to exit in four directions: top, right, bottom, left
* While application works, it prints moves directions into console
* Maze solving application stops, when one from two exits was found
* Lastly, application creates Log.txt file, which contains the trail
