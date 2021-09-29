using System;
using System.Windows.Forms;

namespace TextViewDecorator
{
    public partial class Form1 : Form
    {
        private TextBox textBox;
        private TextView textView;
        private BorderDecorator borderDecorator;
        private ScrollDecorator scrollDecorator;

        public Form1()
        {
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textView = new TextView(this, textBox);
            textView.Draw();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (textView == null)
            {
                return;
            }

            borderDecorator = new BorderDecorator(this, textBox);
            if (scrollDecorator != null)
            {
                borderDecorator.SetComponent(scrollDecorator);

            }
            else
            {
                borderDecorator.SetComponent(textView);
            }

            borderDecorator.Draw();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(textView == null)
            {
                return;
            }

            scrollDecorator = new ScrollDecorator(this, textBox);
            if(borderDecorator != null)
            {
                scrollDecorator.SetComponent(borderDecorator);
            }
            else
            {
                scrollDecorator.SetComponent(textView);
            }
            scrollDecorator.Draw();
        }
    }
}
