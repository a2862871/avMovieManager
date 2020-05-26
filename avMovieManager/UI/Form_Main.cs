using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using avMovieManager.UI;
using avMovieManager.DAL;
using avMovieManager.BLL;
using avMovieManager.Model;

namespace avMovieManager.UI
{
    public partial class Form_Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private PreviewControl previewControl = new PreviewControl();
        public Form_Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //窗口相关
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void OpenChildFrom(Form childFrom) 
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                panelDesktop.Controls.Clear();
            }
            currentChildForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            childFrom.Size = panelDesktop.Size;
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void ActivateButton(object senderBtn,Color color) 
        {
            if (senderBtn != null) 
            {
                DisableButton();
                currentBtn = senderBtn as IconButton;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //设置右边小标签
                leftBorderBtn.Size = new Size(7, currentBtn.Height);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //标题栏子标签
                iconCurrentChildFrom.IconChar = currentBtn.IconChar;
                iconCurrentChildFrom.IconColor = color;
                labelCurrentChildFrom.Text = currentBtn.Text;
            }
        }

        private void DisableButton() 
        {
            if (currentBtn != null) 
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButtonMovies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildFrom(new Form_MoviePreview());
        }
        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildFrom(new Form_SearchMovie());
        }

        private void iconButtonTidy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildFrom(new Form_CollatingSort());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildFrom(new Form_Setting());
        }

        private void BackHome() 
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildFrom.IconChar = IconChar.Home;
            iconCurrentChildFrom.IconColor = Color.MediumPurple;
            labelCurrentChildFrom.Text = "主页";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                panelDesktop.Controls.Clear();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            BackHome();
        }
        //窗口移动
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized) 
            {
                this.WindowState = FormWindowState.Normal;
            }
            else 
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonLastVideo_Click(object sender, EventArgs e)
        {
            //List<int> testlist = new List<int>();
            //for(int i = 0; i < 10000000; i++) 
            //{
            //    Random rd = new Random();
            //    testlist.Add(rd.Next(90523, 10000000));
            //}
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Start();  //开始监视代码运行时间
            //var ccc = testlist.OrderBy(u => u).ToList();
            //watch.Stop();  //停止监视
            //TimeSpan timespan = watch.Elapsed;  //获取当前实例测量得出的总时间
            //System.Diagnostics.Debug.WriteLine("打开窗口代码执行时间：{0}(毫秒)", timespan.TotalMilliseconds);  //总毫秒数
            //return;
            BackHome();
            previewControl.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(previewControl);
            previewControl.Show(MovieDataBLL.GetLastMovieInfos());
        }
    }
}
