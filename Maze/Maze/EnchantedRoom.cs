namespace Maze
{
    class EnchantedRoom : Room
    {
        private Spell spell = null;
        public EnchantedRoom(int number) : base(number) { }

        public EnchantedRoom(int number, Spell spell) : base(number)
        {
            this.spell = spell;
        }
    }
}
