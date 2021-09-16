namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            MazePrototypeFactory mazePrototypeFactory = new MazePrototypeFactory(new Wall(), new Room(), new Door(), new Maze());
            Maze aMaze = mazeGame.CreateMaze(mazePrototypeFactory);
        }
    }
}
