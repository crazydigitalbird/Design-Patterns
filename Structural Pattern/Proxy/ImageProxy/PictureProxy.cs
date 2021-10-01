using ImageProxy.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProxy
{
    class PictureProxy: Graphic
    {
        private Picture picture;

        public PictureProxy(string fileName)
        {
            this.fileName = fileName;
            PictureToShow = new Bitmap(Resources.startImg, 52, 62);
        }

        public override void Draw()
        {
            if(picture == null)
            {
                picture = new Picture(this.fileName);
            }
            picture.Draw();
        }

        public override void Load()
        {
            int index = PicturesList.ListPictures.IndexOf(this);
            PicturesList.ListPictures[index] = this.picture;
        }
    }
}
