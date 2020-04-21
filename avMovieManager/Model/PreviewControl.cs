﻿using System;
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
            for (; i < listPicBox.Count; i++)
            {
                listPicBox[i].ShowImage();
            }
            this.ResumeLayout();
        }
        private void ShowPreviewPic(MovieInfo md, int i)
        {
            PreviewPicControl p = new PreviewPicControl(md);
            int x = 50 + i % 2 * 40 + (((i + 2) % 2) * 600);
            int y = i / 2 * (100 + 404);
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