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
        private actorMovieData movieDate;
        public PreviewPicControl(actorMovieData md)
        {
            InitializeComponent();
            this.movieDate = md;
            this.ContextMenuStrip = contextMenuStrip1;
            buttonPlayer.Tag = movieDate.path;
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
                Button p = (Button)sender;
                string filename = p.Tag.ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = LocalPathParam.VideoPlayerPath;
                process.StartInfo.Arguments = filename;
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
    }
}
