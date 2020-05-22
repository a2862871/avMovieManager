using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.BLL;
using avMovieManager.DAL;
namespace avMovieManager.UI
{
    public partial class Form_CollatingSort : Form
    {

        GetMovieInfo getMovieInfo = new GetMovieInfo();
        public Form_CollatingSort()
        {
            InitializeComponent();
            textBox_log.AutoSize = false;
            textSaveVideoPath.Text = LocalPathParam.WatiMovieSortPath;
            //textSaveVideoPath.Text = @"I:\待分类";
            getMovieInfo.OutLog += GetMovieInfo_OutLog;
            //panel_rename.Visible = false;
            if (textSaveVideoPath.Text.Length > 0)
            {
                if (Directory.Exists(LocalPathParam.WatiMovieSortPath)) 
                {
                    GetAllVideoFile(textSaveVideoPath.Text);
                }
                
            }
        }

        private void GetMovieInfo_OutLog(string log)
        {
            outputlog(log);
        }
        private void GetAllVideoFile(string path) 
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //获取目录下（不包含子目录）的文件和子目录
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo)     //判断是否文件夹
                {
                    GetAllVideoFile(i.FullName);    //递归调用复制子文件夹
                }
                else
                {
                    string ext = i.Extension;
                    if (".mp4".Equals(ext) || ".wmv".Equals(ext) || ".avi".Equals(ext) || ".mkv".Equals(ext))
                    {
                        int index = this.dataGridViewVideo.Rows.Add();
                        this.dataGridViewVideo.Rows[index].Cells[0].Value = i.Name;
                        this.dataGridViewVideo.Rows[index].Cells[1].Value = i.FullName;
                    }

                }
            }
        }
        private void iconButtonOpenFolder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                textSaveVideoPath.Text = dialog.SelectedPath;
                LocalPathParam.WatiMovieSortPath = textSaveVideoPath.Text;
                dataGridViewVideo.Rows.Clear();
                GetAllVideoFile(textSaveVideoPath.Text);
            }
        }

        private void iconButtonStarSort_Click(object sender, EventArgs e)
        {
            Task t1 = new Task(sortmovievideo, TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent);
            t1.Start();
        }
        private void sortmovievideo()
        {
            int index = dataGridViewVideo.Rows.Count - 1;
            for (int i = 0; i < index; i++)
            {
                if (i != 0) 
                {
                    outputlog("-----------------------等待5秒-------------------------");
                    Thread.Sleep(5000);
                }
                outputlog("----------------------------开始-------------------------------");              
                getMovieInfo.StartGetInfo(dataGridViewVideo.Rows[i].Cells[1].Value.ToString(), dataGridViewVideo.Rows[i].Cells[0].Value.ToString());
                GC.Collect();
            }
            outputlog("本次整理完成");
            RefreshDataGridView();

        }
        private void outputlog(string str)
        {
            textBox_log.BeginInvoke(new Action(() =>
            {
                textBox_log.AppendText(System.Environment.NewLine + str);
                textBox_log.ScrollToCaret();
            })
            );

        }

        private void RefreshDataGridView() 
        {
            if (textSaveVideoPath.Text.Length == 0) return;
            dataGridViewVideo.BeginInvoke(new Action(() => {
                if (textSaveVideoPath.Text.Length == 0) return;
                dataGridViewVideo.Rows.Clear();
                GetAllVideoFile(textSaveVideoPath.Text);
            })
            );
        }
        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
