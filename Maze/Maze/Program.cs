namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            MazePrototypeFactory mazePrototypeFactory = new MazePrototypeFactory(new BombedWall(), new RoomWithBomb(), new Door(), new Maze());
            Maze aMaze = mazeGame.CreateMaze(mazePrototypeFactory);
        }
    }
}
