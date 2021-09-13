using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMazeBuilder builder = new StandardMazeBuilder();
            MazeGame mazeGame = new MazeGame();
            mazeGame.CreateMaze(builder);
        }
    }
}
