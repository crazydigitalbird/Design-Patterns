using System;
using System.Windows.Forms;

namespace MacroCommand
{
    public partial class MainForm : Form
    {
        internal static MainForm MainFormInstance { get; private set; }

        internal static Document CurrentDocument { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] {

                new MyMenuItem("Open", new OpenCommand()),
                new MyMenuItem("Close", new CloseCommand()),
                new ToolStripSeparator(),
                new MyMenuItem("Copy", new CopyCommand()),
                new MyMenuItem("Cut", new CutCommand()),
                new MyMenuItem("Paste", new PasteCommand()),
                new ToolStripSeparator(),
                new MyMenuItem("MacroCopy", new MacroCommand(new OpenCommand(),
                                                             new SelectAllTextCommand(),
                                                             new CopyCommand(),
                                                             new CloseCommand()
                                                             ))
            });
            MainFormInstance = this;
        }

        public void AddDocument(Document document)
        {
            document.MdiParent = this;
            document.Show();
        }

        public void Log(string logString)
        {
            this.label1.Text += Environment.NewLine + logString;
        }
    }
}
