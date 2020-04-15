using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.BLL;

namespace avMovieManager.Model
{
    public partial class TagPanelControl : UserControl
    {
        private int labelPointX = 40;
        private int labelPointY = 30;
        private List<string> optTags = new List<string>();
        public TagPanelControl()
        {
            InitializeComponent();
            //LoadTags();
        }
        public void LoadTags() 
        {
            MovieDataBLL mda = MovieDataBLL.Instance;
            List<string> listTags = mda.GetMovieAllTags();
            int i = 0;
            foreach(string tag in listTags) 
            {
                if (labelPointX + 100 > this.Width) 
                {
                    labelPointX = 40;
                    labelPointY += 40;
                }
                Label labelTag = new Label();
                labelTag.AutoSize = true;
                labelTag.BackColor = System.Drawing.Color.Transparent;
                //labelTag.BackColor = System.Drawing.Color.FromArgb(40, 41, 82);
                labelTag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelTag.Location = new System.Drawing.Point(labelPointX, labelPointY);
                labelTag.Name = "labelTag";
                //labelTag.Size = new System.Drawing.Size(102, 27);
                labelTag.TabIndex = i;
                labelTag.Text = tag;
                //labelTag.Text = "这是一个tag";
                labelTag.Tag = 0;
                labelTag.Click += new System.EventHandler(this.labelTag_Click);
                i++;
                panelTag.Controls.Add(labelTag);
                labelPointX = labelPointX + 20 + labelTag.Width;
            }
        }

        private void labelTag_Click(object sender, EventArgs e)
        {
            Label tempLabel = (Label)sender;
            if ((int)tempLabel.Tag == 0) 
            {
                tempLabel.Tag = 1;
                tempLabel.BackColor = System.Drawing.Color.FromArgb(50, 152, 220);
            }
            else 
            {
                tempLabel.Tag = 0;
                tempLabel.BackColor = System.Drawing.Color.FromArgb(40, 41, 82);
            }
        }
    }
}
