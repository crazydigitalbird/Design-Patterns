using System.Collections.Generic;

namespace MacroCommand
{
    class MacroCommand: Command
    {
        public readonly List<Command> Commands = new List<Command>();

        public MacroCommand(params Command[] commands)
        {
            Commands.AddRange(commands);
        }

        public override void Execute()
        {
            if(MainForm.CurrentDocument != null)
            {
                foreach(Command c in Commands)
                {
                    c.Execute();
                }
            }
        }
    }
}
