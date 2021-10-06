using System.Windows.Forms;

namespace MacroCommand
{
    class OpenCommand: Command
    {
        public override void Execute()
        {
            string fileName = AskUser();
            if(!string.IsNullOrWhiteSpace(fileName))
            {
                Document document = new Document();
                document.Open(fileName);
                LogExecution($"opened file: {fileName}");
                MainForm.MainFormInstance.AddDocument(document);
            }
        }

        private string AskUser()
        {
            LogExecution("asking user.");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
