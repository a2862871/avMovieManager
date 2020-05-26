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
using avMovieManager.BLL;

namespace avMovieManager.Model
{
    public partial class PreviewPicControl : UserControl
    {
        private MovieInfo movieDate;
        public PreviewPicControl(MovieInfo md)
        {
            InitializeComponent();
            this.movieDate = md;
            this.ContextMenuStrip = contextMenuStrip1;
            buttonPlayer.MouseClick += ButtonPlayer_MouseClick;
            labelVideoSn.Text = movieDate.MovieSn;
        }

        private void ButtonPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(LocalPathParam.VideoPlayerPath))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = movieDate.Path;
                process.Start();
                process.Close();
            }
        }
        public void AsyncShowImage() 
        {
            pictureBoxCover.LoadAsync(movieDate.ThumbPicPath);
        }
        public void ShowImage() 
        {
            pictureBoxCover.Load(movieDate.ThumbPicPath);
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", movieDate.Path);
        }

        private void javDbSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = AvUrlLink.JavDbUrl + "/search?q=" + movieDate.MovieSn + "&f=all";
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }
        private void javLibrarySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = AvUrlLink.JavLibraryUrl + "vl_searchbyid.php?keyword=" + movieDate.MovieSn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void avMooSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = AvUrlLink.AvMooUrl + "search/" + movieDate.MovieSn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void avSoxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = AvUrlLink.AvSoxUrl + "search/" + movieDate.MovieSn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void javBusSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = AvUrlLink.JavBusUrl + "search/" + movieDate.MovieSn;
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo(url);
            System.Diagnostics.Process.Start(Info);
        }

        private void playAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalPathParam.VideoPlayerPath))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = movieDate.Path;
                process.Start();
                process.Close();
            }
        }

        private void addChineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageHelper.AddImageSignPic(movieDate.ThumbPicPath, movieDate.ThumbPicPath, System.Environment.CurrentDirectory+@"\img\sub.png",1,100,10);
            ImageHelper.AddImageSignPic(movieDate.PosterPicPath, movieDate.PosterPicPath, System.Environment.CurrentDirectory + @"\img\sub.png", 1, 100, 10);
            pictureBoxCover.LoadAsync(movieDate.ThumbPicPath);
            DirectoryInfo dir = new DirectoryInfo(movieDate.Path);
            FileInfo[] fileInfo = dir.GetFiles("*.nfo");
            foreach (FileInfo item in fileInfo)
            {
                XmlHelper.AddXmlChildNode(item.FullName,"tag", "中文字幕");
            }
        }
    }
}
