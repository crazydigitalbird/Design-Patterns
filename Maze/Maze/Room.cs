using System;
using System.Collections.Generic;

namespace Maze
{
    public class Room : MapSite
    {
        int roomNumber;
        Dictionary<Direction, MapSite> sides;

        public Room() { }

        public Room(int number)
        {
            this.roomNumber = number;
            sides = new Dictionary<Direction, MapSite>(4);
        }

        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[direction];
        }

        public void SetSide(Direction direction, MapSite mapSide)
        {
            sides.Add(direction, mapSide);
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public virtual Room Clone()
        {
            return new Room(this.roomNumber);
        }

        public virtual void Initialize(int number)
        {
            this.roomNumber = number;
        }
    }
}
