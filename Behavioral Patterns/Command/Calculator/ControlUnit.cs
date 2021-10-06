using System.Collections.Generic;

namespace Calculator
{
    // "Invoker" (Инициатор) - Устройство управления (УУ)
    class ControlUnit
    {
        private int current = 0;

        private List<Command> commands = new List<Command>();

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    commands[--current].UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    commands[current++].Execute();
                }
            }
        }
    }
}
