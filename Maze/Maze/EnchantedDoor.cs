using System;

namespace Maze
{
    class EnchantedDoor : Door
    {
        public EnchantedDoor(Room room1, Room room2) : base(room1 , room2) { }

        public override void Enter()
        {
            Console.WriteLine("Enchanted Door");
        }
    }
}
