using System;

namespace Maze
{
    class MazeFactory
    {
        private static MazeFactory instance = null;

        protected MazeFactory() { }

        public static MazeFactory Instance()
        {
            if (instance == null)
            {
                string mazeStyle = Environment.GetEnvironmentVariable("MAZESTYLE");
                if (string.Compare(mazeStyle, "bombed") == 0)
                {
                    instance = new BombedMazeFactory();
                }
                else if (string.Compare(mazeStyle, "enchanted") == 0)
                {
                    instance = new EnchantedMazeFactory();
                }
                else
                {
                    instance = new MazeFactory();
                }
            }
            return instance;
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
