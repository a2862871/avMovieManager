using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.BLL;
using avMovieManager.DAL;
namespace avMovieManager.UI
{
    public partial class Form_MoviePreview : Form
    {
        private Button currentbtn = null;
        private MovieData movieData = MovieData.Instance;
        private List<PictureBox> listPicBox = new List<PictureBox>();
        public Form_MoviePreview()
        {
            InitializeComponent();
            InitButton();
            panelChildBtnMenu.AutoScroll = true;
        }
        private void InitButton() 
        {
            
            List<string> filelist = movieData.GetActorAllName();
            for (int i = filelist.Count-1; i >= 0; i--)
            {
                Button b = new Button();
                b.Dock = System.Windows.Forms.DockStyle.Top;
                b.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                b.FlatAppearance.BorderSize = 0;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.ForeColor = System.Drawing.Color.Gainsboro;
                b.Location = new System.Drawing.Point(0, 0);
                b.Name = "btn_" + i.ToString();
                b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                b.Size = new System.Drawing.Size(panelChildBtnMenu.Size.Width, 50);
                b.TabIndex = i;
                b.Text = filelist[i];
                b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                b.UseVisualStyleBackColor = true;
                b.MouseClick += B_MouseClick;
                b.BringToFront();
                panelChildBtnMenu.Controls.Add(b);
            }
        }

        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentbtn != null)
            {
                if (currentbtn == (Button)sender)
                    return;
                currentbtn.BackColor = Color.FromArgb(34, 33, 74);
            }
            currentbtn = (Button)sender;
            currentbtn.BackColor = RGBColors.color5;
            ShowActorCover(currentbtn.Text);
        }
        private void ShowActorCover(string name) 
        {
            panelPicSubMenu.Controls.Clear();
            listPicBox.Clear();
            Console.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
            List<actorMovieData> movieDatas = movieData.GetActorMoviesAllPath(name);
            for (int i = 0; i < movieDatas.Count; i++) 
            {
                ShowPreviewPic(movieDatas[i], i);
            }
            Console.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
            //var result = Task.Run(() => LoadPicImage(movieDatas));

        }
        private void LoadPicImage(List<actorMovieData> movieDatas) 
        {
            for (int i = 0; i < movieDatas.Count; i++)
            {
                //listPicBox[i].LoadAsync(movieDatas[i].movieJpgPath);
                listPicBox[i].Image =movieDatas[i].movieimg;
            }
        }

        private void ShowPreviewPic(actorMovieData md,int i) 
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            int x = 50 + i % 2 * 40 + (((i + 2) % 2) * 600);
            int y = i / 2 * (100 + 404);
            pb.Location = new Point(x, y);
            pb.Size = new Size(600, 404);
            //pb.Image = Image.FromFile(md.movieJpgPath);
            pb.Image = md.movieimg;
            pb.Tag = md.moviePath;
            listPicBox.Add(pb);

            Label lb = new Label();
            lb.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            if (md.movieischinese)
            {
                lb.Text = md.moviesn + "    中文字幕";
                lb.Location = new Point(pb.Location.X + 220, pb.Location.Y + 404 + 10);
            }
            else
            {
                lb.Text = md.moviesn;
                lb.Location = new Point(pb.Location.X + 280, pb.Location.Y + 404 + 10);
            }
            lb.ForeColor = Color.Gainsboro;
            lb.AutoSize = true;
            lb.BackColor = panelPicSubMenu.BackColor;
            lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lb.Tag = md.moviesn;
            //lb.MouseDoubleClick += Lb_MouseDoubleClick;
            //lb.Width = (lb.Text.Length - 1) * (int)lb.Font.Size;

            PictureBox pb1 = new PictureBox();
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.Location = new Point(lb.Location.X + 150, lb.Location.Y - 5);
            pb1.Image = global::avMovieManager.Properties.Resources.playermovie;
            pb1.Size = new Size(40, 32);
            pb1.Tag = md.moviePath;
            pb1.MouseClick += Pb1_MouseClick;

            panelPicSubMenu.Controls.Add(pb);
            panelPicSubMenu.Controls.Add(lb);
            panelPicSubMenu.Controls.Add(pb1);

        }
        private void Pb1_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(LocalPathParam.VideoPlayerPath))
            {
                PictureBox p = (PictureBox)sender;
                string filename = p.Tag.ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = filename;
                process.Start();
                process.Close();
            }
        }
    }
}
