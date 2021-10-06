using System.Windows.Forms;

namespace MacroCommand
{
    class PasteCommand: Command
    {
        public override void Execute()
        {
            if(MainForm.CurrentDocument != null)
            {
                LogExecution($"paste text: {Clipboard.GetText()}");
                MainForm.CurrentDocument.Paste();
            }
        }
    }
}
