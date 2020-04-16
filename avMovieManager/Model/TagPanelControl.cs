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
        private bool isLoadTags = false;
        private List<string> optTags = new List<string>();
        public delegate void ButtonMouseDown(List<string> tags);
        public event ButtonMouseDown Button_SearchTagsEvent;
        public TagPanelControl()
        {
            InitializeComponent();
            //var result = Task.Run(() => LoadTags());
            //LoadTags();
        }
        public void LoadTagsSync() 
        {
            var result = Task.Run(() => LoadTags());
        }
        public bool IsLoadComplate() 
        {
            return isLoadTags;
        }
        private void LoadTags() 
        {
            if (isLoadTags) return;
            List<string> listTags = MovieDataBLL.GetMovieAllTags();
            //System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
            int i = 0;
            foreach (string tag in listTags) 
            {
                if (labelPointX + 70 > this.Width) 
                {
                    labelPointX = 40;
                    labelPointY += 40;
                }
                Label labelTag = new Label();
                labelTag.AutoSize = true;
                labelTag.BackColor = System.Drawing.Color.Transparent;
                //labelTag.BackColor = System.Drawing.Color.FromArgb(40, 41, 82);
                labelTag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelTag.ForeColor = System.Drawing.Color.Gainsboro;
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
            isLoadTags = true;
            //System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
        }

        private void labelTag_Click(object sender, EventArgs e)
        {
            Label tempLabel = (Label)sender;
            if ((int)tempLabel.Tag == 0) 
            {
                if (optTags.Count > 5)
                {
                    MessageBox.Show("Tag选择数量超过上限，最高6个,选多了也出不来");
                    return;
                }
                else
                {
                    optTags.Add(tempLabel.Text);
                }
                tempLabel.Tag = 1;
                tempLabel.BackColor = System.Drawing.Color.FromArgb(50, 152, 220);
                ShowSelectTags();
            }
            else 
            {
                tempLabel.Tag = 0;
                tempLabel.BackColor = System.Drawing.Color.Transparent;
                optTags.Remove(tempLabel.Text);
                ShowSelectTags();
            }
        }
        private void ShowSelectTags()
        {
            panelSelectLabel.Controls.Clear();
            int PointX = 40;
            int PointY = 10;
            foreach (string tag in optTags)
            {
                Label labelTag = new Label();
                labelTag.AutoSize = true;
                labelTag.BackColor = System.Drawing.Color.FromArgb(50, 152, 220);
                //labelTag.BackColor = System.Drawing.Color.FromArgb(40, 41, 82);
                labelTag.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                labelTag.ForeColor = System.Drawing.Color.Gainsboro;
                labelTag.Location = new System.Drawing.Point(PointX, PointY);
                labelTag.Text = tag;
                panelSelectLabel.Controls.Add(labelTag);
                PointX = PointX + 20 + labelTag.Width;
            }
        }
        private void buttonSearchTags_Click(object sender, EventArgs e)
        {
            Button_SearchTagsEvent(optTags);
        }
    }
}
