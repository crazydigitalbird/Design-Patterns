namespace Maze
{
    abstract class MazeBuilder
    {
        public abstract void BuilderMaze();

        public abstract void BuilderRoom(int number);

        public abstract void BuilderDoor(int roomFrom, int roomTo);

        public abstract Maze GetMaze();
    }
}
