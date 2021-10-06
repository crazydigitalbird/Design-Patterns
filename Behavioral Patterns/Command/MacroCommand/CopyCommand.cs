namespace MacroCommand
{
    class CopyCommand: Command
    {
        public override void Execute()
        {
            if(MainForm.CurrentDocument != null)
            {
                LogExecution($"copy text: {MainForm.CurrentDocument.DocumentContent.SelectedText}");
                MainForm.CurrentDocument.Copy();
            }
        }
    }
}
