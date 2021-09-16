namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            MazeFactory mazeFactory = MazeFactory.Instance();
            Maze aMaze = mazeGame.CreateMaze(mazeFactory);
        }
    }
}
