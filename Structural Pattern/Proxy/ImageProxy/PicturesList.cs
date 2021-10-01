using System.Collections.Generic;

namespace ImageProxy
{
    class PicturesList
    {
        public static List<Graphic> ListPictures { get; set; }

        static PicturesList()
        {
            ListPictures = new List<Graphic>();
        }
    }
}
