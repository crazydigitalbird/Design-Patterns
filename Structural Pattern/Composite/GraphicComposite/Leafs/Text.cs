using System;
using System.Drawing;

namespace GraphicComposite.Leafs
{
    class Text : IGraphic
    {
        private string text;
        private Font font;
        private Brush brush;
        private Point point;

        public Text(Color color, string text, int x, int y)
        {
            this.text = text;
            this.point = new Point(x, y);
            this.font = new Font("Arial", 20);
            this.brush = new SolidBrush(color);
        }

        public void Draw(Graphics device)
        {
            device.DrawString(text, font, brush, point);
        }

        public void Add(IGraphic graphic)
        {
            throw new NotImplementedException();
        }

        public IGraphic GetChild(int child)
        {
            throw new NotImplementedException();
        }

        public void Remove(IGraphic graphic)
        {
            throw new NotImplementedException();
        }
    }
}
