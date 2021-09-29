using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicComposite.Leafs
{
    class Circle : IGraphic
    {
        private Color color;
        private int x;
        private int y;
        private int radius;

        public Circle(Color color, int x, int y, int radius)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public void Draw(Graphics device)
        {
            device.DrawEllipse(new Pen(color, 5), x - radius, y - radius , radius + radius, radius + radius);
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
