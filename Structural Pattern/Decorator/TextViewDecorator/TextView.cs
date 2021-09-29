using System.Windows.Forms;

namespace TextViewDecorator
{
    class TextView: VisualComponent
    {
        public TextView(Form form, TextBox textBox): base(form, textBox) { }
        public override void Draw()
        {
            TextBox.Location = new System.Drawing.Point(10, 30);
            TextBox.Width = Form.Width - 40;
            Form.Controls.Add(TextBox);
            Form.ResumeLayout(false);
        }
    }
}