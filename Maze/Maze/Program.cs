using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            Maze maze = mazeGame.CreateMaze();
        }
    }
}
