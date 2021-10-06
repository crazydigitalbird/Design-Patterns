namespace MacroCommand
{
    class CutCommand : Command
    {
        public override void Execute()
        {
            if (MainForm.CurrentDocument != null)
            {
                LogExecution($"cut text: {MainForm.CurrentDocument.DocumentContent.SelectedText}");
                MainForm.CurrentDocument.Cut();
            }
        }
    }
}
