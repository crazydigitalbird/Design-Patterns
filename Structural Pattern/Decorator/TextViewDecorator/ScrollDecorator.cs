using System.Windows.Forms;

namespace TextViewDecorator
{
    class ScrollDecorator: Decorator
    {
        public ScrollDecorator(Form form, TextBox textBox): base(form, textBox) { }

        private void ScrollDraw()
        {
            TextBox.Multiline = true;
            TextBox.Height = Form.Height - 100;
            TextBox.ScrollBars = ScrollBars.Vertical;
        }

        public override void Draw()
        {
            base.Draw();
            ScrollDraw();
        }
    }
}
