using System.Windows.Forms;

namespace BridgeWindow
{
    abstract class Window
    {
        protected WindowImp implementor;

        protected Form form;
        protected Button button;

        public virtual void Draw()
        {
            this.form.Controls.Add(button);
            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}
