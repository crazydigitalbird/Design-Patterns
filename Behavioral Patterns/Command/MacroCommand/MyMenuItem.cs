using System;
using System.Windows.Forms;

namespace MacroCommand
{
    class MyMenuItem: ToolStripMenuItem
    {
        public Command MenuCommand { get; set; }

        public MyMenuItem(string text, Command command): base(text)
        {
            this.MenuCommand = command;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(MenuCommand != null)
            {
                MenuCommand.Execute();
            }
        }
    }
}
