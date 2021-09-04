using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            Maze aMaze = mazeGame.CreateMaze();
        }
    }
}
