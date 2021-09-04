namespace Maze
{
    class MazeGame
    {
        MazeFactory factory = null;
        public Maze CreateMaze(MazeFactory factory)
        {
            this.factory = factory;
            Maze aMaze = this.factory.MakeMaze();
            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);
            Door theDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, this.factory.MakeWall());
            r1.SetSide(Direction.South, this.factory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.West, this.factory.MakeWall());

            r2.SetSide(Direction.North, this.factory.MakeWall());
            r2.SetSide(Direction.South, this.factory.MakeWall());
            r2.SetSide(Direction.East, this.factory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}
