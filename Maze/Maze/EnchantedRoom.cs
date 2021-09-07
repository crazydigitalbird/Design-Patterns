using System;

namespace Maze
{
    class EnchantedRoom : Room
    {
        public EnchantedRoom(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine("Enchanted Room");
        }
    }
}
