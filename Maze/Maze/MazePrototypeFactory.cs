namespace Maze
{
    class MazePrototypeFactory : MazeFactory
    {
        private Wall prototypeWall = null;
        private Room prototypeRoom = null;
        private Door prototypeDoor = null;
        private Maze prototypeMaze = null;

        public MazePrototypeFactory(Wall wall, Room room, Door door, Maze maze)
        {
            this.prototypeWall = wall;
            this.prototypeRoom = room;
            this.prototypeDoor = door;
            this.prototypeMaze = maze;
        }

        public override Wall MakeWall()
        {
            return prototypeWall.Clone();
        }

        public override Room MakeRoom(int number)
        {
            Room cloneRoom = prototypeRoom.Clone();
            cloneRoom.Initialize(number);
            return cloneRoom;
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            Door cloneDoor = prototypeDoor.Clone();
            cloneDoor.Initialize(room1, room2);
            return cloneDoor;
        }

        public override Maze MakeMaze()
        {
            return prototypeMaze.Clone();
        }
    }
}
