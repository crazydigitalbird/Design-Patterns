using GraphicComposite.Leafs;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicComposite
{
    public partial class Form1 : Form
    {
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Composite";
            this.BackColor = Color.White;
            this.graphics = this.CreateGraphics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            IGraphic root = new Picture();
            IGraphic branch = new Picture();

            IGraphic lineA = new Line(Color.Red, 10, 150, 258, 150);
            IGraphic lineB = new Line(Color.Gold, 30, 100, 240, 100);

            IGraphic rectangleA = new Leafs.Rectangle(Color.Green, 10, 10, 250, 250);
            IGraphic rectangelB = new Leafs.Rectangle(Color.LightGreen, 30, 30, 208, 100);

            IGraphic circle = new Circle(Color.BlueViolet, 130, 205, 30);

            IGraphic text = new Text(Color.Gray, "Дима", 90, 50);

            root.Add(branch);
            root.Add(lineA);
            root.Add(rectangleA);
            root.Add(circle);

            branch.Add(lineB);
            branch.Add(rectangelB);
            branch.Add(text);

            root.Draw(graphics);
        }
    }
}
