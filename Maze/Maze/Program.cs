using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new EnchantedMazeGame();
            Maze maze = mazeGame.CreateMaze();
        }
    }
}
