using System.Windows.Forms;

namespace TextViewDecorator
{
    class BorderDecorator: Decorator
    {
        public BorderDecorator(Form form, TextBox textBox):base(form, textBox) { }

        private void DrawBorder()
        {
            TextBox.BorderStyle = BorderStyle.FixedSingle;
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder();
        }
    }
}
