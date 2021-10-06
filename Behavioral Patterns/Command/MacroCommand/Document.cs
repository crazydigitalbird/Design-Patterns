using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MacroCommand
{
    public partial class Document : Form
    {
        static int docsCount;

        public RichTextBox DocumentContent { get; private set; }

        public Document() : base()
        {
            DocumentContent = new RichTextBox();
            DocumentContent.ShortcutsEnabled = false;
            DocumentContent.Parent = this;
            DocumentContent.Dock = DockStyle.Fill;
            this.Text = $"Новый документ № {docsCount++}";
        }

        protected override void OnActivated(EventArgs e)
        {
            MainForm.CurrentDocument = this;
            base.OnActivated(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            MainForm.CurrentDocument = null;
            base.OnClosing(e);
        }

        public void Open(string fileName)
        {
            if(File.Exists(fileName))
            {
                this.Text = fileName;
                DocumentContent.Text = File.ReadAllText(fileName);
            }
        }

        public new void Close()
        {
            base.Close();
        }

        public void Copy()
        {
            DocumentContent.Copy();
        }

        public void Cut()
        {
            DocumentContent.Cut();
        }

        public void Paste()
        {
            DocumentContent.Paste();
        }
    }
}
