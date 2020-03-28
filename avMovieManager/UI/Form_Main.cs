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

namespace avMovieManager.UI
{
    public partial class Form_Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
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
            var result = Task.Run(() => InitDB());
        }
        private void InitDB() 
        {
            FullMovieDatas movieData = FullMovieDatas.Instance;
        }
        private void OpenChildFrom(Form childFrom) 
        {
            if (currentChildForm != null) 
            {
                currentChildForm.Close();
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
        }

        private void iconButtonTidy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildFrom(new Form_CollatingSort());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildFrom.IconChar = IconChar.Home;
            iconCurrentChildFrom.IconColor = Color.MediumPurple;
            labelCurrentChildFrom.Text = "主页";
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


    }
}
