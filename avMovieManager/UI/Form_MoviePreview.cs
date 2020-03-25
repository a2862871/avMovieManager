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
    public partial class Form_MoviePreview : Form
    {
        public Form_MoviePreview()
        {
            InitializeComponent();
            InitButton();
            panelChildBtnMenu.AutoScroll = true;
        }
        private void InitButton() 
        {
            BLL.MovieData movdata = BLL.MovieData.Instance;
            List<string> filelist = movdata.GetActorName();
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
                b.BringToFront();
                panelChildBtnMenu.Controls.Add(b);
            }
        }
    }
}
