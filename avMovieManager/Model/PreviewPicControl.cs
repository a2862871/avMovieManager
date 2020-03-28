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
using System.IO;

namespace avMovieManager.Model
{
    public partial class PreviewPicControl : UserControl
    {
        private ActorMovieData movieDate;
        public PreviewPicControl(ActorMovieData md)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.movieDate = md;
            this.ContextMenuStrip = contextMenuStrip1;
            buttonPlayer.MouseClick += ButtonPlayer_MouseClick;
            if (movieDate.isChinese)
            {
                labelVideoSn.Text = movieDate.sn + "    中文字幕";
            }
            else
            {
                labelVideoSn.Text = movieDate.sn;
            }
        }

        private void ButtonPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(LocalPathParam.VideoPlayerPath))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = movieDate.path;
                process.Start();
                process.Close();
            }
        }

        public void ShowImage() 
        {
            if (LocalPathParam.PicIsLoadALL.Equals("1"))
            {
                pictureBoxCover.Image = movieDate.img;
            }
            else
            {
                pictureBoxCover.LoadAsync(movieDate.jpgPath);
            }
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", movieDate.path);
        }

        private void javDbSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = SearchUrlLink.JavDbUrl + "/search?q=" + movieDate.sn + "&f=all";
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }
        private void javLibrarySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = SearchUrlLink.JavLibraryUrl + "vl_searchbyid.php?keyword=" + movieDate.sn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void avMooSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = SearchUrlLink.AvMooUrl + "search/" + movieDate.sn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void avSoxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = SearchUrlLink.AvSoxUrl + "search/" + movieDate.sn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void javBusSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = SearchUrlLink.JavBusUrl + "search/" + movieDate.sn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void playAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalPathParam.VideoPlayerPath))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = movieDate.actorPath;
                process.Start();
                process.Close();
            }
        }

        private void addChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = movieDate.path + "\\" + "ch.uid";
            if (!File.Exists(file)) 
            {
                File.Create(file);
            }
        }
    }
}
