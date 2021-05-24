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

## Example:
```
Original Maze
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
1 1 1 1 1 1 1 1 0 0 0 0 0 0 0 0 0 0 1 1
1 1 1 1 1 0 1 1 0 1 1 1 1 1 1 1 1 0 0 0
1 1 1 1 1 2 1 1 0 1 0 0 0 0 0 1 1 0 1 1
1 1 1 1 1 0 1 1 0 0 0 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 1 1 1 1 1 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 1 1 1 1 1 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 1 1 1 1 1 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 1 1 0 0 0 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 1 1 0 1 0 1 1 1 0 1 1 0 1 1
1 1 1 1 1 0 0 0 0 1 0 0 0 0 0 1 1 0 1 1
1 1 1 1 1 1 0 1 1 1 1 1 1 1 1 1 1 0 1 1
1 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 0 1 1
1 0 1 1 1 1 1 1 1 1 1 1 1 0 1 1 1 0 1 1
1 0 0 0 1 1 1 1 1 1 1 1 1 0 1 1 1 0 1 1
1 1 1 0 1 1 1 1 1 1 0 0 0 0 1 1 1 0 1 1
1 1 1 0 0 1 1 1 1 1 0 1 1 1 1 1 1 0 1 1
1 1 1 1 0 1 1 1 1 1 0 0 0 0 0 0 0 0 1 1
0 0 0 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
```

```
Solved Maze
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 
1 1 1 1 1 1 1 1 2 2 2 2 2 2 2 2 2 2 1 1 
1 1 1 1 1 2 1 1 2 1 1 1 1 1 1 1 1 2 2 2 
1 1 1 1 1 2 1 1 2 1 2 2 2 2 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 2 2 2 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 1 1 1 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 1 1 1 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 1 1 1 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 2 2 2 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 1 1 2 1 2 1 1 1 2 1 1 0 1 1 
1 1 1 1 1 2 2 2 2 1 2 2 2 2 2 1 1 0 1 1 
1 1 1 1 1 1 0 1 1 1 1 1 1 1 1 1 1 0 1 1 
1 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 0 1 1 
1 0 1 1 1 1 1 1 1 1 1 1 1 0 1 1 1 0 1 1 
1 0 0 0 1 1 1 1 1 1 1 1 1 0 1 1 1 0 1 1 
1 1 1 0 1 1 1 1 1 1 0 0 0 0 1 1 1 0 1 1 
1 1 1 0 0 1 1 1 1 1 0 1 1 1 1 1 1 0 1 1 
1 1 1 1 0 1 1 1 1 1 0 0 0 0 0 0 0 0 1 1 
0 0 0 0 0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 
```

```
Maze Log
The current maze position has been changed to 4,6.
The current maze position has been changed to 3,6.
The current maze position has been changed to 4,6.
The current maze position has been changed to 5,6.
The current maze position has been changed to 6,6.
The current maze position has been changed to 7,6.
The current maze position has been changed to 8,6.
The current maze position has been changed to 9,6.
The current maze position has been changed to 10,6.
The current maze position has been changed to 11,6.
The current maze position has been changed to 11,7.
The current maze position has been changed to 11,8.
The current maze position has been changed to 11,9.
The current maze position has been changed to 10,9.
The current maze position has been changed to 9,9.
The current maze position has been changed to 9,10.
The current maze position has been changed to 9,11.
The current maze position has been changed to 10,11.
The current maze position has been changed to 11,11.
The current maze position has been changed to 11,12.
The current maze position has been changed to 11,13.
The current maze position has been changed to 11,14.
The current maze position has been changed to 11,15.
The current maze position has been changed to 10,15.
The current maze position has been changed to 9,15.
The current maze position has been changed to 8,15.
The current maze position has been changed to 7,15.
The current maze position has been changed to 6,15.
The current maze position has been changed to 5,15.
The current maze position has been changed to 4,15.
The current maze position has been changed to 4,14.
The current maze position has been changed to 4,13.
The current maze position has been changed to 4,12.
The current maze position has been changed to 4,11.
The current maze position has been changed to 5,11.
The current maze position has been changed to 5,10.
The current maze position has been changed to 5,9.
The current maze position has been changed to 4,9.
The current maze position has been changed to 3,9.
The current maze position has been changed to 2,9.
The current maze position has been changed to 2,10.
The current maze position has been changed to 2,11.
The current maze position has been changed to 2,12.
The current maze position has been changed to 2,13.
The current maze position has been changed to 2,14.
The current maze position has been changed to 2,15.
The current maze position has been changed to 2,16.
The current maze position has been changed to 2,17.
The current maze position has been changed to 2,18.
The current maze position has been changed to 3,18.
The current maze position has been changed to 3,19.
The current maze position has been changed to 3,20.
Application has been successfully reached to exit at coordinates 3, 20
```
