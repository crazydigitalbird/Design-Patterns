namespace Maze
{
    class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuilderMaze();
            builder.BuilderRoom(1);
            builder.BuilderRoom(2);
            builder.BuilderDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            for (int i = 0; i < 1001; i++)
            {
                builder.BuilderRoom(i);
            }

            return builder.GetMaze();
        }
    }
}
