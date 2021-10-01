using System.Drawing;

namespace ImageProxy
{
    abstract class Graphic
    {
        public string fileName;
        public abstract void Draw();
        public abstract void Load();
        public Image PictureToShow { get; set; }
    }
}
