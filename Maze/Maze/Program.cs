using System;
using System.Threading;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();

            Maze maze = mazeGame.CreateMaze();

            Random random = new Random();

            //Вводим игрока в лабиринт (комната выбирается случайным образом).
            Room room = maze.RoomNo(random.Next(1, 3));

            //Выбранная сторона
            MapSite site = null;

            //Начало прохождения лабиринта.
            while(true)
            {
                //Выюор новой стороны случайным образом.
                switch(random.Next(1,5))
                {
                    case 1:
                        site = room.GetSide(Direction.North);
                        break;
                        
                    case 2:
                        site = room.GetSide(Direction.South);
                        break;

                    case 3:
                        site = room.GetSide(Direction.East);
                        break;

                    case 4:
                        site = room.GetSide(Direction.West);
                        break;
                }

                Console.Write($"Я в комнате {room.RoomNumber}. Делаю шаг - ");

                // Попытка сделать шаг в выбранную сторону.
                site.Enter();

                // Если дверь, то перейти в другую комнату.
                if(site is Door door)
                {
                    // Переход в другую комнату (Получение ссылки на новую комнату).
                    room = door.OtherSideFrom(room);
                }

                // Задержка между шагами.
                Thread.Sleep(1000);
            }
        }
    }
}
