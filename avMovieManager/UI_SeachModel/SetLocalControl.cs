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
using avMovieManager.BLL;
using System.Threading;
using System.Diagnostics;

namespace avMovieManager.UI_SeachModel
{
    public partial class SetLocalControl : UserControl
    {
        public SetLocalControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            labelPlayer.Text = LocalPathParam.VideoPlayerPath;
            labelVideoPath.Text = LocalPathParam.VideoPreviewPath;
            labelWaitClassify.Text=LocalPathParam.WatiMovieSortPath;
            labelClassifyOut.Text=LocalPathParam.SortFinalOutPath;
        }

        private void ucSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ucSwitch1.Checked) 
            {
                LocalPathParam.PicIsLoadALL = true;
                IniHelper.Write("LoadPic", "LoadALL", "1");
            }
            else 
            {
                LocalPathParam.PicIsLoadALL = false;
                IniHelper.Write("LoadPic", "LoadALL", "0");
            }
            MessageBox.Show("修改此功能需要重启客户端，客户端即将重启");
            Application.ExitThread();
            Restart();
        }

        private void ucBtnPlayer_BtnClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "所有文件(*.exe*)|*.exe*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelPlayer.Text = dialog.FileName;
            }
            LocalPathParam.VideoPlayerPath = labelPlayer.Text;
            IniHelper.Write("PlayerPath", "Path", LocalPathParam.VideoPlayerPath);
        }

        private void ucBtnVideoPath_BtnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择存放影片的文件夹";
            string currpath = labelVideoPath.Text;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelVideoPath.Text = dialog.SelectedPath; 
            }
            LocalPathParam.VideoPreviewPath = labelVideoPath.Text;
            IniHelper.Write("MoviePath", "Path", LocalPathParam.VideoPreviewPath);
            if (!currpath.Equals(labelVideoPath.Text)) 
            {
                MessageBox.Show("修改目录需要重启客户端，客户端即将重启");
                Application.ExitThread();
                Restart();
            }
        }

        private void ucBtnWaitClassify_BtnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择存放未分类影片的文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelWaitClassify.Text = dialog.SelectedPath; 
            }
            LocalPathParam.WatiMovieSortPath = labelWaitClassify.Text;
            IniHelper.Write("WaitClassifyPath", "WaitClassify", LocalPathParam.WatiMovieSortPath);
        }

        private void ucBtnExtClassifyOut_BtnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择存放分类完成后的影片文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                labelClassifyOut.Text = dialog.SelectedPath; 
            }
            LocalPathParam.SortFinalOutPath = labelClassifyOut.Text;
            IniHelper.Write("SortOutPath", "OutPath", LocalPathParam.SortFinalOutPath);
        }

        private void Restart()
        { 
            Thread thtmp = new Thread(new ParameterizedThreadStart(run));
            object appName = Application.ExecutablePath;
            Thread.Sleep(1000);
            thtmp.Start(appName);
        }
        private void run(Object obj)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }
    }
}
