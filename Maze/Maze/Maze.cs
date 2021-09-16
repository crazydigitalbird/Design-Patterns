using System.Collections.Generic;

namespace Maze
{
    class Maze
    {
        Dictionary<int, Room> rooms;

        public Maze()
        {
            this.rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return rooms[number];
        }

        public virtual Maze Clone()
        {
            return new Maze();
        }
    }
}
