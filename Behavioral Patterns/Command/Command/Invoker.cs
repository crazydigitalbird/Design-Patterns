namespace Command
{
    class Invoker
    {
        private Command command;

        public void StoreCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            if(command != null)
            {
                command.Execute();
            }
        }
    }
}
