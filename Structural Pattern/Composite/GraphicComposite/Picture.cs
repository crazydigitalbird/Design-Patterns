using System.Collections.Generic;
using System.Drawing;

namespace GraphicComposite
{
    class Picture : IGraphic
    {
        List<IGraphic> nodes;

        public Picture()
        {
            this.nodes = new List<IGraphic>(); ;
        }

        public void Add(IGraphic graphic)
        {
            this.nodes.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            this.nodes.Remove(graphic);
        }

        public IGraphic GetChild(int child)
        {
            return this.nodes[child];
        }

        public void Draw(Graphics graphics)
        {
            foreach(IGraphic node in nodes)
            {
                node.Draw(graphics);
            }
        }
    }
}
