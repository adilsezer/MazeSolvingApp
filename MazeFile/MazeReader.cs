using System;
using System.IO;

namespace MazeSolvingApp
{
    public static class MazeReader
    {
        private static string[] mazeText;
        public static int[,] maze;
        private static int mazeHeight = 0;
        private static int mazeWidth = 0;
        public static int startX = -1;
        public static int startY = -1;
        public static bool readerStatus;
        private static bool getMazeStatus;
        private static bool createMazeStatus;
        private const string mazeFile = "RPAMaze.txt";
        private const string logFile = "Log.txt";

        public static void ReadMaze()
        {
            CreateLog();
            GetMaze();

            if (getMazeStatus)
            {
                CreateMaze();
            }
            //output for Program.cs    
            readerStatus = getMazeStatus && createMazeStatus;
        }

        private static void GetMaze()
        {
            try
            {
                //reading RPAMaze.txt file and specifying maze details
                using (var sr = new StreamReader(mazeFile))
                {
                    mazeText = sr.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    mazeHeight = Convert.ToInt32(mazeText[0].Split(' ')[0]);
                    mazeWidth = Convert.ToInt32(mazeText[0].Split(' ')[1]);
                    maze = new int[mazeHeight, mazeWidth];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e} Exception caught.");
            }
            //output for ReadMaze method
            getMazeStatus = mazeHeight > 0 && mazeWidth > 0;
        }

        private static void CreateMaze()
        {
            //creating matrix
            for (var i = 0; i < mazeHeight; i++)
            {
                string[] mazeRow = mazeText[i + 1].Split(' ');
                if (mazeRow.Length == mazeWidth)
                {
                    for (var j = 0; j < mazeWidth; j++)
                    {
                        int currentvalue = Int32.Parse(mazeRow[j]);
                        if (currentvalue == 2 && startX == -1)
                        {
                            startX = i;
                            startY = j;
                        }
                        maze[i, j] = currentvalue;
                        Console.Write(currentvalue + " ");
                    }
                }
                Console.WriteLine();
            }
            //output statu, sets to true if maze matrix contains starting point
            createMazeStatus = startX != -1;
        }

        private static void CreateLog()
        {
            //Delete and create Log.txt file
            if (File.Exists(logFile))
            {
                File.Delete(logFile);
            }
            using (var streamWriter = new StreamWriter(logFile, false))
            {
                streamWriter.Write("Maze Log\n");
            }
        }
    }
}