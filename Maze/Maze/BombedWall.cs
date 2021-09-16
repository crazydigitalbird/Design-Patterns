using System;

namespace Maze
{
    class BombedWall : Wall
    {
        bool bomb;

        public BombedWall() { }

        public BombedWall(BombedWall bombedWall)
        {
            this.bomb = bombedWall.bomb;
        }

        public override void Enter()
        {
            Console.WriteLine("Bombed Wall");
        }

        public override Wall Clone()
        {
            return new BombedWall(this);
        }

        public bool HasBomb()
        {
            return this.bomb;
        }
    }
}
