using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new BombedMazeGame();
            Maze maze = mazeGame.CreateMaze();
        }
    }
}
