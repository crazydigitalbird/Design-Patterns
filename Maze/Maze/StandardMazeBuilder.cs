namespace Maze
{
    class StandardMazeBuilder : MazeBuilder
    {
        private Maze currentMaze = null;

        public override void BuilderMaze()
        {
            this.currentMaze = new Maze();
        }

        public override void BuilderRoom(int number)
        {
            Room room = new Room(number);
            this.currentMaze.AddRoom(room);

            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
        }

        public override void BuilderDoor(int roomFrom, int roomTo)
        {
            Room room1 = currentMaze.RoomNo(roomFrom);
            Room room2 = currentMaze.RoomNo(roomTo);
            Door door = new Door(room1, room2);

            room1.UpdateSide(CommonWall(room1, room2), door);
            room2.UpdateSide(CommonWall(room2, room1), door);
        }

        public override Maze GetMaze()
        {
            return currentMaze;
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            if (room1.GetSide(Direction.East) is Wall &&
                room1.GetSide(Direction.West) is Wall &&
                room1.GetSide(Direction.North) is Wall &&
                room1.GetSide(Direction.South) is Wall &&
                room2.GetSide(Direction.East) is Wall &&
                room2.GetSide(Direction.West) is Wall &&
                room2.GetSide(Direction.North) is Wall &&
                room2.GetSide(Direction.South) is Wall)
            {
                return Direction.East;
            }
            else
            {
                return Direction.West;
            }
        }
    }
}
