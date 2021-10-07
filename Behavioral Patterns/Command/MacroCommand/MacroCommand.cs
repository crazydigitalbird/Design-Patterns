using System.Collections.Generic;

namespace MacroCommand
{
<<<<<<< HEAD
<<<<<<< HEAD
    class MacroCommand : Command
		
    class MacroCommand: Command
    {
        public readonly List<Command> Commands = new List<Command>();

        public MacroCommand(params Command[] commands)
        {
            Commands.AddRange(commands);
        }

        public override void Execute()
        {
            foreach (Command c in Commands)
            {
                c.Execute();
            }
        }
    }
}
