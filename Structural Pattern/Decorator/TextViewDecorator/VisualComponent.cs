using System.Windows.Forms;

namespace TextViewDecorator
{
    abstract class VisualComponent
    {
        public Form Form { get; set; }

        public TextBox TextBox { get; set; }

        protected VisualComponent(Form form, TextBox textBox)
        {
            this.Form = form;
            this.TextBox = textBox;
        }

        public abstract void Draw();
    }
}