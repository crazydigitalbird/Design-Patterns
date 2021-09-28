using System.Windows.Forms;

namespace BridgeWindow
{
    abstract class WindowImp
    {
        protected Form form;
        protected Button button;

        public abstract Form DevDrawForm();
        public abstract Button DevDrawButton();

    }
}
