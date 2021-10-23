using System;

namespace FlagDrow
{
    class PolandFlag : TwoColorFlag
    {
        protected override void DrawBottonPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 20));
        }

        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 20));
        }
    }
}
