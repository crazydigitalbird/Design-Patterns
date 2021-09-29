using System.Drawing;

namespace GraphicComposite
{
    interface IGraphic
    {
        void Add(IGraphic graphic);

        void Remove(IGraphic graphic);

        void Draw(Graphics device);

        IGraphic GetChild(int child);
    }
}
