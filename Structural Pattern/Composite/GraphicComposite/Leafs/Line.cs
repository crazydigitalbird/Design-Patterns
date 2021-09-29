using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite.Leafs
{
    class Line : IGraphic
    {
        private Color color;
        private Point x;
        private Point y;

        public Line(Color color, int x1, int y1, int x2, int y2)
        {
            this.color = color;
            this.x = new Point(x1, y1);
            this.y = new Point(x2, y2);
        }

        public void Draw(Graphics device)
        {
            device.DrawLine(new Pen(this.color, 5), x, y);
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
