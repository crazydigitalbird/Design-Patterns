using System.Drawing;
using System.Windows.Forms;

namespace BridgeWindow
{
    class MSWindowImp : WindowImp
    {
        public override Form DevDrawForm()
        {
            this.form = new Form();
            this.form.AutoScaleDimensions = new SizeF(6F, 13F);
            this.form.AutoScaleMode = AutoScaleMode.Font;
            this.form.ClientSize = new Size(284, 172);
            this.form.Name = "Microsoft Forlm";
            this.form.Text = "Windows Explorer";
            this.form.BackColor = Color.LightBlue;

            return this.form;
        }

        public override Button DevDrawButton()
        {
            this.button = new Button();
            this.button.Location = new Point(75, 70);
            this.button.Size = new Size(127, 25);
            this.button.Text = "Windows";
            this.button.ForeColor = Color.Aqua;
            this.button.BackColor = Color.DarkBlue;

            return this.button;
        }
    }
}
