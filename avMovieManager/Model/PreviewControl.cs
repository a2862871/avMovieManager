using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.DAL;

namespace avMovieManager.Model
{
    public partial class PreviewControl : UserControl
    {
        private List<PreviewPicControl> listPicBox = new List<PreviewPicControl>();
        public PreviewControl()
        {
            InitializeComponent();
        }
        public void Show(List<MovieInfo> movieDatas) 
        {
            this.Controls.Clear();
            listPicBox.Clear();
            GC.Collect();
            for (int i = 0; i < movieDatas.Count; i++)
            {
                ShowPreviewPic(movieDatas[i], i);
            }
            if (listPicBox.Count < 4)
            {
                LoadPicImage(0);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    listPicBox[i].ShowImage();
                }
                var result = Task.Run(() => LoadPicImage(4));
            }
        }

        private void LoadPicImage(int i)
        {
            this.SuspendLayout();
            int count = listPicBox.Count;
            if (count > 100) 
            {
                count = 100;  //防止数量太多，后期优化
            }
            for (; i < count; i++)
            {
                listPicBox[i].AsyncShowImage();
            }
            this.ResumeLayout();
        }
        private void ShowPreviewPic(MovieInfo md, int i)
        {
            int w = SystemInformation.WorkingArea.Width;
            int index = 2;
            if (w > 1920) 
            {
                index = 3;
            }
            PreviewPicControl p = new PreviewPicControl(md);
            int x = 50 + i % index * 40 + (((i + index) % index) * 600);
            int y = i / index * (100 + 404);
            p.Tag = i;
            p.Location = new Point(x, y);
            listPicBox.Add(p);
            this.Controls.Add(p);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PreviewControl
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(756, 461);
            this.ResumeLayout(false);

        }
    }
}
