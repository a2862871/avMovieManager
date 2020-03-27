using avMovieManager.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avMovieManager.UI
{
    public partial class Form_SplashScreen : Form
    {
        private int currindex = 0;
        public Form_SplashScreen()
        {
            InitializeComponent();
            FullMovieDatas.Progress += MovieData_Progress;
            FullMovieDatas movieData = FullMovieDatas.Instance;
        }

        private void MovieData_Progress(int index, int count, string name)
        {
            if (currindex == index)
                return;
            currindex = index;
            labelProgress.BeginInvoke(new Action(() =>
            {
                labelProgress.Text = string.Format("加载ing,当前进度{0}/{1},正在加载" + name + "的图片", index, count);
                panelProgressbar.Width += (700 / count)+1;
                if (index == count)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }));

        }
    }
}
