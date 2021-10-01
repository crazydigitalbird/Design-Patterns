using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageProxy
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog browserDialog;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(browserDialog.SelectedPath);
                foreach(FileInfo file in dir.GetFiles("*.jpg"))
                {
                    PicturesList.ListPictures.Add(new PictureProxy(file.FullName));
                }

                InitPictures();
            }
        }

        private void InitPictures()
        {
            this.listView1.Items.Clear();
            this.imageList1.Images.Clear();

            foreach(var pics in PicturesList.ListPictures)
            {
                this.imageList1.Images.Add(pics.PictureToShow);
                this.imageList1.ImageSize = new Size(54, 62);
            }

            this.listView1.View = View.LargeIcon;
            this.listView1.LargeImageList = this.imageList1;

            for (int i = 0; i < this.imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                this.listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                if(PicturesList.ListPictures[e.ItemIndex] is Picture)
                {
                    Image image = PicturesList.ListPictures[e.ItemIndex].PictureToShow;
                    this.pictureBox1.Image = new Bitmap(image, pictureBox1.Width, pictureBox1.Height) as Image;
                }
                else
                {
                    PicturesList.ListPictures[e.ItemIndex].Draw();
                    PicturesList.ListPictures[e.ItemIndex].Load();
                    Image image = PicturesList.ListPictures[e.ItemIndex].PictureToShow;
                    this.pictureBox1.Image = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                    this.imageList1.Images[e.ItemIndex] = new Bitmap(pictureBox1.Image, 52, 62);
                }
            }
        }
    }
}
