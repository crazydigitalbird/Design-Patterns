namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            //MazeFactory mazeFactory = new MazeFactory();
            //EnchantedMazeFactory mazeFactory = new EnchantedMazeFactory();
            BombedMazeFactory mazeFactory = new BombedMazeFactory();
            Maze aMaze = mazeGame.CreateMaze(mazeFactory);
        }
    }
}
