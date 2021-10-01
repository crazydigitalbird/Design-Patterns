using System;
using System.Drawing;

namespace ImageProxy
{
    class Picture: Graphic
    {
        public Picture(string fileName)
        {
            this.fileName = fileName;
        }

        public override void Draw()
        {
            PictureToShow = Image.FromFile(this.fileName);
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
