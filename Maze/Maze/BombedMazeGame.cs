namespace Maze
{
    class BombedMazeGame : MazeGame
    {
        public override Room MakeRoom(int number)
        {
            return new RoomWhithBomb(number);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}
