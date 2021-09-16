using System;

namespace Maze
{
    class RoomWithBomb : Room
    {
        public RoomWithBomb() : base() { } 

        public RoomWithBomb(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine("Room with bomb");
        }

        public override Room Clone()
        {
            return new Room();
        }
    }
}
