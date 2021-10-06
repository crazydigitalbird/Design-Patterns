namespace MacroCommand
{
    class CloseCommand: Command
    {
        public override void Execute()
        {
            if(MainForm.CurrentDocument != null)
            {
                LogExecution($"{MainForm.CurrentDocument.Text} close");
                MainForm.CurrentDocument.Close();
            }
        }
    }
}
