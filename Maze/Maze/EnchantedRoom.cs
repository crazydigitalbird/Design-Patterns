using System;

namespace Maze
{
    class EnchantedRoom : Room
    {
        public EnchantedRoom(int number, Spell spell) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine("Enchanted Room");
        }
    }
}
