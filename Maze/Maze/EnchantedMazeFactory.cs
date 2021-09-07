namespace Maze
{
    class EnchantedMazeFactory: MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number, GetSpell());
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        protected Spell GetSpell()
        {
            return null;
        }
    }

    class Spell
    {

    }
}
